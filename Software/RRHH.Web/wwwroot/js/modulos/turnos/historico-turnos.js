// RF-02: histórico de turnos de un empleado, con periodo opcional.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { lineaTiempo } from '../../componentes/graficos.js';
import { chip, vacio } from '../../componentes/ui.js';
import { mostrarFecha } from '../../componentes/fechas.js';

const dias = f => Math.round((new Date(f.fechaFin) - new Date(f.fechaInicio)) / 86400000) + 1;

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <div data-selector-empleado="empleado"></div>
      <label>Desde <small>(opcional)</small><input name="desde" type="date"></label>
      <label>Hasta <small>(opcional)</small><input name="hasta" type="date"></label>
      <div class="acciones"><button class="btn btn-primario">Consultar histórico</button></div>
    </form>
    <div class="indicadores separado"></div>
    <section class="tarjeta" data-resultado>
      <div class="tarjeta-cabecera"><div><h2>Historial de asignaciones</h2><p>Cada tramo es un periodo con turno distinto al estable.</p></div></div>
      <div data-linea></div>
      <div class="resultados separado-chico"></div>
    </section>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const linea = contenedor.querySelector('[data-linea]');
  const resultados = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario);
  resultados.append(vacio('Elija un empleado y consulte su histórico.', 'calendario'));

  alEnviar(formulario, async datos => {
    resultados.replaceChildren();
    linea.replaceChildren();
    const filas = await api('horarios/historico?' + consulta(datos));
    const conFechas = filas.filter(f => f.fechaInicio && f.fechaFin);
    indicadores(resumen, [
      ['Asignaciones', filas.length, { icono: 'turnos' }],
      ['Turnos distintos', new Set(filas.map(f => f.horarioAsignado)).size, { icono: 'calendario', tono: 'cian' }],
      ['Días con turno asignado', conFechas.reduce((s, f) => s + dias(f), 0), { icono: 'reportes', tono: 'exito' }]
    ]);
    lineaTiempo(linea, conFechas.map(f => ({ desde: f.fechaInicio, hasta: f.fechaFin, texto: `N.º ${f.n} · ${f.descrip_Horario}` })));
    tabla(resultados, ['N.º', 'Desde', 'Hasta', 'Turno', 'Horario', 'Documento', 'Sisgedo'],
      filas.map(f => [f.n, mostrarFecha(f.fechaInicio) || '—', mostrarFecha(f.fechaFin) || '—', chip(f.descrip_Horario, 'marca'),
        [f.ingreso1, f.salida2].filter(Boolean).join(' – '), f.nroDocumento || '—', f.sisgedo || '—']),
      'No hay asignaciones por periodo en el rango consultado.');
  });
}
