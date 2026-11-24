// RF-15: labores presenciales y días de teletrabajo por persona, con una categoría por día.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores, rangosRapidos } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { dona, calendario } from '../../componentes/graficos.js';
import { chip, vacio } from '../../componentes/ui.js';
import { hoy, inicioDeMes, mostrarFecha } from '../../componentes/fechas.js';

// Tono del calendario y de la etiqueta según la categoría que devuelve la API.
const TONO = { 'Presencial': 'marca', 'Remoto': 'cian', 'Ausencia': 'aviso', 'Sin registro': 'peligro', 'No laborable': 'gris' };
const si = valor => (valor ? 'Sí' : 'No');

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <div data-selector-empleado="empleado"></div>
      <label>Desde<input name="desde" type="date" required></label>
      <label>Hasta<input name="hasta" type="date" required></label>
      <div class="acciones"><button class="btn btn-primario">Consolidar</button></div>
      <div data-rangos></div>
    </form>
    <div class="indicadores separado"></div>
    <div class="rejilla columnas-2">
      <section class="tarjeta">
        <div class="tarjeta-cabecera"><div><h2>Distribución de días laborables</h2><p>Cada día cuenta en una sola categoría.</p></div></div>
        <div data-dona></div>
      </section>
      <section class="tarjeta">
        <div class="tarjeta-cabecera"><div><h2>Calendario</h2><p>Presencial · Teletrabajo · Ausencia · Sin registro · No laborable</p></div></div>
        <div data-calendario></div>
      </section>
    </div>
    <section class="tarjeta sin-relleno">
      <div class="tarjeta-cabecera"><div><h2>Detalle diario</h2><p>«Revisar» señala fuentes en conflicto (por ejemplo, marcación en un día de ausencia aprobada).</p></div></div>
      <div class="resultados separado-chico"></div>
    </section>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const grafico = contenedor.querySelector('[data-dona]');
  const mes = contenedor.querySelector('[data-calendario]');
  const detalle = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario);
  valores(formulario, { desde: inicioDeMes(), hasta: hoy() });
  rangosRapidos(formulario);
  for (const destino of [grafico, mes, detalle]) destino.append(vacio('Elija un empleado y consolide su asistencia.', 'teletrabajo'));

  alEnviar(formulario, async datos => {
    const r = await api('asistencia/consolidada?' + consulta(datos));
    indicadores(resumen, [
      ['Laborables', r.laborables, { icono: 'calendario' }],
      ['Presenciales', r.presenciales, { icono: 'personas' }],
      ['Teletrabajo', r.remotos, { icono: 'teletrabajo', tono: 'cian' }],
      ['Ausencias', r.ausencias, { icono: 'permisos', tono: 'aviso' }],
      ['Sin registro', r.sinRegistro, { icono: 'alerta', tono: 'peligro' }],
      ['Por revisar', r.inconsistencias, { icono: 'info', tono: r.inconsistencias ? 'peligro' : 'exito' }]
    ]);
    dona(grafico, [
      { etiqueta: 'Presencial', valor: r.presenciales, color: '#5b5bf6' },
      { etiqueta: 'Teletrabajo', valor: r.remotos, color: '#22c3e6' },
      { etiqueta: 'Ausencia', valor: r.ausencias, color: '#f59e0b' },
      { etiqueta: 'Sin registro', valor: r.sinRegistro, color: '#ef4444' }
    ], { valor: r.laborables, texto: 'laborables' });
    calendario(mes, r.dias.map(d => ({ fecha: d.fecha, clase: TONO[d.categoria] ?? '', titulo: d.categoria })));
    tabla(detalle, ['Fecha', 'Categoría', 'Ausencia aprobada', 'Marcación', 'Periodo remoto', 'Revisión'],
      r.dias.map(d => [mostrarFecha(d.fecha), chip(d.categoria, TONO[d.categoria] === 'gris' ? '' : TONO[d.categoria]), si(d.ausencia),
        si(d.presencial), si(d.remoto), d.inconsistencia ? chip('Revisar', 'peligro') : '—']));
  });
}
