// RF-14: días de teletrabajo computados en un periodo (descuenta fines de semana y feriados).

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla } from '../../componentes/tabla.js';
import { hoy, inicioDeMes } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta">
      <div data-selector-empleado="empleado"></div>
      <label>Desde<input type="date" name="desde" required></label>
      <label>Hasta<input type="date" name="hasta" required></label>
      <div class="acciones"><button>Calcular días</button></div>
    </form>
    <p class="nota">Sin empleado se listan todas las personas con teletrabajo en el periodo. Máximo 367 días.</p>
    <div class="resultados"></div>`));
  const formulario = contenedor.querySelector('form');
  const resultados = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario, 'empleado', { requerido: false });
  valores(formulario, { desde: inicioDeMes(), hasta: hoy() });

  alEnviar(formulario, async datos => {
    resultados.replaceChildren();
    const filas = await api('reporte?' + consulta(datos));
    tabla(resultados, ['Código de empleado', 'Días de teletrabajo'], filas.map(f => [f.idEmpleado, f.dias]),
      'Nadie registra teletrabajo en el periodo consultado.');
  });
}
