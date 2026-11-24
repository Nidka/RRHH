// RF-15: labores presenciales y días de teletrabajo por persona, con una categoría por día.

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
      <div class="acciones"><button>Consolidar asistencia</button></div>
    </form>
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
    const r = await api('asistencia/consolidada?' + consulta(datos));
    indicadores(resumen, [['Laborables', r.laborables], ['Presenciales', r.presenciales], ['Teletrabajo', r.remotos],
      ['Ausencias', r.ausencias], ['Sin registro', r.sinRegistro], ['Por revisar', r.inconsistencias]]);
    tabla(detalle, ['Fecha', 'Categoría', 'Ausencia aprobada', 'Marcación', 'Periodo remoto', 'Inconsistencia'],
      r.dias.map(d => [mostrarFecha(d.fecha), d.categoria, si(d.ausencia), si(d.presencial), si(d.remoto), d.inconsistencia ? 'Revisar' : 'No']));
  });
}
