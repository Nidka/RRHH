// RF-17: asistencia de un empleado con feriados y fines de semana sumados una sola vez.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { hoy, inicioDeMes, mostrarFecha } from '../../componentes/fechas.js';

const si = valor => (valor ? 'Sí' : 'No');

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta">
      <div data-selector-empleado="empleado"></div>
      <label>Desde<input name="desde" type="date" required></label>
      <label>Hasta<input name="hasta" type="date" required></label>
      <label>Modo<select name="modo"><option value="A">Asistencias (suma días no laborables)</option><option value="P">Productividad (solo días trabajados)</option></select></label>
      <div class="acciones"><button>Generar reporte</button></div>
    </form>
    <p class="nota">Un feriado que cae en fin de semana, o un día con asistencia que además es feriado, se cuenta una sola vez.</p>
    <div class="indicadores"></div>
    <div class="resultados"></div>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const detalle = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario);
  valores(formulario, { desde: inicioDeMes(), hasta: hoy() });

  alEnviar(formulario, async datos => {
    resumen.replaceChildren();
    detalle.replaceChildren();
    const r = await api('asistencia?' + consulta(datos));
    indicadores(resumen, [
      ['Días computados', r.total],
      ['No laborables', r.dias.filter(d => d.noLaborable).length],
      ['Con asistencia', r.dias.filter(d => d.asistio).length]
    ]);
    tabla(detalle, ['Fecha', 'Asistencia registrada', 'No laborable', 'Cuenta en el total'],
      r.dias.map(d => [mostrarFecha(d.fecha), si(d.asistio), si(d.noLaborable), si(d.cuentaEnTotal)]));
  });
}
