// RF-02: histórico de turnos de un empleado, con periodo opcional.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla } from '../../componentes/tabla.js';
import { mostrarFecha } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta">
      <div data-selector-empleado="empleado"></div>
      <label>Desde (opcional)<input name="desde" type="date"></label>
      <label>Hasta (opcional)<input name="hasta" type="date"></label>
      <div class="acciones"><button>Consultar histórico</button></div>
    </form>
    <div class="resultados"></div>`));
  const formulario = contenedor.querySelector('form');
  const resultados = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario);

  alEnviar(formulario, async datos => {
    resultados.replaceChildren();
    const filas = await api('horarios/historico?' + consulta(datos));
    tabla(resultados, ['N.º', 'Desde', 'Hasta', 'Turno', 'Entrada', 'Salida', 'Documento', 'Sisgedo'],
      filas.map(fila => [fila.n, mostrarFecha(fila.fechaInicio) || '—', mostrarFecha(fila.fechaFin) || '—',
        fila.descrip_Horario, fila.ingreso1 ?? '', fila.salida2 ?? '', fila.nroDocumento ?? '', fila.sisgedo ?? '']),
      'No hay asignaciones por periodo en el rango consultado.');
  });
}
