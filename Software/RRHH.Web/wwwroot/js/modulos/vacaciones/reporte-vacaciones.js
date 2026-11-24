// RF-11: reporte acumulado de vacaciones por año, con filtros de área y empleado.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla } from '../../componentes/tabla.js';
import { hoy } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta">
      <label>Año del padrón<input name="anio" type="number" min="1900" max="9998" required></label>
      <label>Corte dentro del año<input name="corte" type="date" required></label>
      <label>Área (opcional)<input name="area" type="number" min="1" max="2147483647"></label>
      <div data-selector-empleado="empleado"></div>
      <div class="acciones"><button>Generar reporte</button></div>
    </form>
    <p class="nota">Las truncas se simulan al corte indicado; no representan una liquidación al cese.</p>
    <div class="resultados"></div>`));
  const formulario = contenedor.querySelector('form');
  const resultados = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario, 'empleado', { requerido: false });
  valores(formulario, { anio: new Date().getFullYear(), corte: hoy() });

  alEnviar(formulario, async datos => {
    resultados.replaceChildren();
    const filas = await api('vacaciones/reporte?' + consulta(datos));
    tabla(resultados, ['Empleado', 'Área', 'Generadas', 'Usadas', 'Pendientes', 'Truncas al corte', 'Observación'],
      filas.map(f => [f.empleado, f.area ?? '', f.generadas ?? '—', f.usadas ?? '—', f.pendientes ?? '—', f.truncasAlCorte ?? '—', f.error ?? '']),
      'No hay empleados en el padrón con esos filtros.');
  });
}
