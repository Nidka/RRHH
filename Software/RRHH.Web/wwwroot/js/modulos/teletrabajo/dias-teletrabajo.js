// RF-14: días de teletrabajo computados en un periodo (descuenta fines de semana y feriados).

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores, rangosRapidos } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { barras } from '../../componentes/graficos.js';
import { nombresDe } from '../../componentes/nombres.js';
import { persona, vacio } from '../../componentes/ui.js';
import { hoy, inicioDeMes } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <div data-selector-empleado="empleado"></div>
      <label>Desde<input type="date" name="desde" required></label>
      <label>Hasta<input type="date" name="hasta" required></label>
      <div class="acciones"><button class="btn btn-primario">Calcular días</button></div>
      <div data-rangos></div>
    </form>
    <div class="indicadores separado"></div>
    <div class="rejilla ancha-angosta">
      <section class="tarjeta sin-relleno">
        <div class="tarjeta-cabecera"><div><h2>Días por persona</h2><p>Sin empleado se listan todas las personas con teletrabajo. Máximo 367 días.</p></div></div>
        <div class="resultados separado-chico"></div>
      </section>
      <section class="tarjeta">
        <div class="tarjeta-cabecera"><div><h2>Comparativo</h2><p>Personas con más días remotos.</p></div></div>
        <div data-grafico></div>
      </section>
    </div>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const resultados = contenedor.querySelector('.resultados');
  const grafico = contenedor.querySelector('[data-grafico]');
  selectorEnFormulario(formulario, 'empleado', { requerido: false });
  valores(formulario, { desde: inicioDeMes(), hasta: hoy() });
  rangosRapidos(formulario);
  resultados.append(vacio('Elija el periodo y calcule los días.', 'teletrabajo'));

  alEnviar(formulario, async datos => {
    resultados.replaceChildren();
    grafico.replaceChildren();
    const filas = await api('reporte?' + consulta(datos));
    const nombres = await nombresDe(filas.map(f => f.idEmpleado));
    const nombre = f => nombres.get(f.idEmpleado)?.nombreCompleto || `Empleado ${f.idEmpleado}`;
    const total = filas.reduce((s, f) => s + f.dias, 0);
    indicadores(resumen, [
      ['Personas', filas.length, { icono: 'personas' }],
      ['Días de teletrabajo', total, { icono: 'teletrabajo', tono: 'cian', detalle: 'descontando fines de semana y feriados' }]
    ]);
    tabla(resultados, ['Persona', 'Días de teletrabajo'],
      filas.map(f => [persona(nombre(f), `código ${f.idEmpleado}`, f.idEmpleado), f.dias]),
      'Nadie registra teletrabajo en el periodo consultado.');
    barras(grafico, [...filas].sort((a, b) => b.dias - a.dias).slice(0, 8).map(f => ({ etiqueta: nombre(f), valor: f.dias })));
  });
}
