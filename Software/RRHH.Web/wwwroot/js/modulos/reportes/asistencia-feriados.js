// RF-17: asistencia de un empleado con feriados y fines de semana sumados una sola vez.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores, rangosRapidos } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { calendario } from '../../componentes/graficos.js';
import { chip, vacio } from '../../componentes/ui.js';
import { hoy, inicioDeMes, mostrarFecha } from '../../componentes/fechas.js';

const si = valor => (valor ? 'Sí' : 'No');

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <div data-selector-empleado="empleado"></div>
      <label>Desde<input name="desde" type="date" required></label>
      <label>Hasta<input name="hasta" type="date" required></label>
      <label>Modo<select name="modo"><option value="A">Asistencias (suma no laborables)</option><option value="P">Productividad (solo días trabajados)</option></select></label>
      <div class="acciones"><button class="btn btn-primario">Generar reporte</button></div>
      <div data-rangos></div>
    </form>
    <p class="nota separado"><svg class="icono"><use href="#i-info"/></svg><span>En el modo Asistencias cada fecha suma como máximo un día: un feriado en fin de semana, o una marcación en un feriado, no se cuentan dos veces.</span></p>
    <div class="indicadores"></div>
    <div class="rejilla ancha-angosta">
      <section class="tarjeta sin-relleno">
        <div class="tarjeta-cabecera"><div><h2>Detalle por fecha</h2><p>Asistencia registrada, días no laborables y si la fecha cuenta en el total.</p></div></div>
        <div class="resultados separado-chico"></div>
      </section>
      <section class="tarjeta">
        <div class="tarjeta-cabecera"><div><h2>Calendario</h2><p>Con asistencia · No laborable · Sin registro</p></div></div>
        <div data-calendario></div>
      </section>
    </div>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const detalle = contenedor.querySelector('.resultados');
  const mes = contenedor.querySelector('[data-calendario]');
  selectorEnFormulario(formulario);
  valores(formulario, { desde: inicioDeMes(), hasta: hoy() });
  rangosRapidos(formulario);
  for (const destino of [detalle, mes]) destino.append(vacio('Elija un empleado y genere el reporte.', 'reportes'));

  alEnviar(formulario, async datos => {
    const r = await api('asistencia?' + consulta(datos));
    indicadores(resumen, [
      ['Días computados', r.total, { icono: 'ok', tono: 'exito' }],
      ['No laborables', r.dias.filter(d => d.noLaborable).length, { icono: 'calendario', tono: 'cian', detalle: 'fines de semana y feriados' }],
      ['Con asistencia', r.dias.filter(d => d.asistio).length, { icono: 'personas' }]
    ]);
    tabla(detalle, ['Fecha', 'Asistencia', 'No laborable', 'Cuenta en el total'],
      r.dias.map(d => [mostrarFecha(d.fecha), si(d.asistio), d.noLaborable ? chip('No laborable', 'cian') : '—',
        d.cuentaEnTotal ? chip('Cuenta', 'exito') : chip('No cuenta')]));
    calendario(mes, r.dias.map(d => ({ fecha: d.fecha, clase: d.asistio ? 'marca' : d.noLaborable ? 'cian' : 'gris',
      titulo: d.asistio ? 'Con asistencia' : d.noLaborable ? 'No laborable' : 'Sin registro' })));
  });
}
