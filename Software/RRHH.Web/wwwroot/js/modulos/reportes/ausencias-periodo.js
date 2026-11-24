// RF-18: quiénes están de vacaciones, licencia, enfermedad u otro motivo entre dos fechas.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores, opciones, rangosRapidos } from '../../componentes/formulario.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { barras } from '../../componentes/graficos.js';
import { persona, chip, vacio } from '../../componentes/ui.js';
import { hoy, inicioDeMes, mostrarFecha } from '../../componentes/fechas.js';

export async function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <label>Desde<input type="date" name="desde" required></label>
      <label>Hasta<input type="date" name="hasta" required></label>
      <label>Motivo<select name="motivo"><option value="">Todos los motivos</option></select></label>
      <div class="acciones"><button class="btn btn-primario">Consultar ausencias</button></div>
      <div data-rangos></div>
    </form>
    <p class="nota separado"><svg class="icono"><use href="#i-info"/></svg><span>Incluye toda ausencia que se cruce con el periodo, aunque empiece antes o termine después. Los permisos anulados no se cuentan.</span></p>
    <div class="indicadores"></div>
    <div class="rejilla ancha-angosta">
      <section class="tarjeta sin-relleno">
        <div class="tarjeta-cabecera"><div><h2>Personas ausentes</h2><p>Días de cada ausencia que caen dentro del periodo.</p></div></div>
        <div class="resultados separado-chico"></div>
      </section>
      <section class="tarjeta">
        <div class="tarjeta-cabecera"><div><h2>Por motivo</h2><p>Cantidad de ausencias.</p></div></div>
        <div data-grafico></div>
      </section>
    </div>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const resultados = contenedor.querySelector('.resultados');
  const grafico = contenedor.querySelector('[data-grafico]');
  valores(formulario, { desde: inicioDeMes(), hasta: hoy() });
  rangosRapidos(formulario);
  for (const destino of [resultados, grafico]) destino.append(vacio('Elija el periodo y consulte las ausencias.', 'calendario'));

  alEnviar(formulario, async datos => {
    const filas = await api('ausencias?' + consulta(datos));
    const porMotivo = new Map();
    for (const f of filas) porMotivo.set(f.motivo, (porMotivo.get(f.motivo) || 0) + 1);
    indicadores(resumen, [
      ['Personas ausentes', new Set(filas.map(f => f.idEmpleado)).size, { icono: 'personas', tono: 'aviso' }],
      ['Ausencias', filas.length, { icono: 'calendario' }],
      ['Días en el periodo', filas.reduce((s, f) => s + f.diasEnPeriodo, 0), { icono: 'reportes', tono: 'cian' }]
    ]);
    tabla(resultados, ['Persona', 'Motivo', 'Inicio', 'Fin', 'Días en el periodo'], filas.map(f => [
      persona(f.empleado?.replace(/\s+/g, ' ').trim(), `código ${f.idEmpleado}`, f.idEmpleado), chip(f.motivo, 'aviso'),
      mostrarFecha(f.inicio), mostrarFecha(f.fin), f.diasEnPeriodo
    ]), 'Nadie se ausenta en el periodo consultado.');
    barras(grafico, [...porMotivo].sort((a, b) => b[1] - a[1]).map(([etiqueta, valor]) => ({ etiqueta, valor })), 'Sin ausencias en el periodo.');
  });

  opciones(formulario.elements.motivo, await api('ausencias/motivos'));
}
