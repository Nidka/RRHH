// RF-09: vacaciones truncas simuladas al último día de servicio (incluido).

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { indicadores } from '../../componentes/tabla.js';
import { hoy, mostrarFecha } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <p class="nota">Es una simulación al cese indicado; no reemplaza la liquidación de beneficios.</p>
    <form class="tarjeta">
      <div data-selector-empleado="empleado"></div>
      <label>Último día de servicio (incluido)<input name="cese" type="date" required></label>
      <div class="acciones"><button>Calcular truncas</button></div>
    </form>
    <p class="estado" role="status"></p>
    <div class="indicadores"></div>`));
  const formulario = contenedor.querySelector('form');
  const estado = contenedor.querySelector('.estado');
  const resultado = contenedor.querySelector('.indicadores');
  selectorEnFormulario(formulario);
  valores(formulario, { cese: hoy() });

  alEnviar(formulario, async datos => {
    resultado.replaceChildren();
    estado.textContent = '';
    const calculo = await api('vacaciones/truncas?' + consulta(datos));
    estado.textContent = `Ingreso ${mostrarFecha(calculo.ingreso)} · cese ${mostrarFecha(calculo.cese)}`;
    indicadores(resultado, [['Días por año', calculo.diasAnuales], ['Días truncos', calculo.truncas.toFixed(2)]]);
  });
}
