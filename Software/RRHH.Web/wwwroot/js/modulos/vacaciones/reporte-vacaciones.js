// RF-11: reporte acumulado de vacaciones por año, con filtros de área y empleado.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { progreso } from '../../componentes/graficos.js';
import { nombresDe } from '../../componentes/nombres.js';
import { persona, chip, vacio } from '../../componentes/ui.js';
import { hoy } from '../../componentes/fechas.js';

const suma = (filas, campo) => filas.reduce((s, f) => s + (f[campo] ?? 0), 0);

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <label>Año del padrón<input name="anio" type="number" min="1900" max="9998" required></label>
      <label>Corte dentro del año<input name="corte" type="date" required></label>
      <label>Área <small>(opcional)</small><input name="area" type="number" min="1" max="2147483647"></label>
      <div data-selector-empleado="empleado"></div>
      <div class="acciones"><button class="btn btn-primario">Generar reporte</button></div>
    </form>
    <div class="indicadores separado"></div>
    <section class="tarjeta sin-relleno">
      <div class="tarjeta-cabecera"><div><h2>Detalle por persona</h2><p>Las truncas se simulan al corte; no representan una liquidación al cese.</p></div></div>
      <div class="resultados separado-chico"></div>
    </section>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const resultados = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario, 'empleado', { requerido: false });
  valores(formulario, { anio: new Date().getFullYear(), corte: hoy() });
  resultados.append(vacio('Elija los filtros y genere el reporte.', 'reportes'));

  alEnviar(formulario, async datos => {
    resultados.replaceChildren();
    resumen.replaceChildren();
    const filas = await api('vacaciones/reporte?' + consulta(datos));
    const nombres = await nombresDe(filas.map(f => f.empleado));
    const completas = filas.filter(f => !f.error);
    indicadores(resumen, [
      ['Personas', filas.length, { icono: 'personas' }],
      ['Días generados', suma(completas, 'generadas'), { icono: 'vacaciones', tono: 'cian' }],
      ['Días usados', suma(completas, 'usadas'), { icono: 'calendario', tono: 'aviso' }],
      ['Días pendientes', suma(completas, 'pendientes'), { icono: 'ok', tono: 'exito', detalle: `${filas.length - completas.length} con datos incompletos` }]
    ]);
    tabla(resultados, ['Persona', 'Área', 'Generadas', 'Uso', 'Pendientes', 'Truncas al corte', 'Observación'], filas.map(f => [
      persona(nombres.get(f.empleado)?.nombreCompleto, `código ${f.empleado}`, f.empleado), f.area ?? '—', f.generadas ?? '—',
      f.generadas ? progreso(f.usadas ?? 0, f.generadas, `${f.usadas ?? 0} usadas`) : '—',
      f.pendientes ?? '—', f.truncasAlCorte ?? '—', f.error ? chip(f.error, 'aviso') : chip('Completo', 'exito')
    ]), 'No hay empleados en el padrón con esos filtros.');
  });
}
