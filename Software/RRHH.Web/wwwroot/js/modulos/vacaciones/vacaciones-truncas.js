// RF-09: vacaciones truncas simuladas al último día de servicio (incluido).

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { indicadores } from '../../componentes/tabla.js';
import { hoy, mostrarFecha } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <div data-selector-empleado="empleado"></div>
      <label>Último día de servicio (incluido)<input name="cese" type="date" required></label>
      <div class="acciones"><button class="btn btn-primario">Calcular truncas</button></div>
    </form>
    <p class="nota separado"><svg class="icono"><use href="#i-info"/></svg><span>Es una simulación al cese indicado: la fracción del año en curso proporcional al régimen. No reemplaza la liquidación de beneficios.</span></p>
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
    indicadores(resultado, [
      ['Días por año', calculo.diasAnuales, { icono: 'vacaciones' }],
      ['Días truncos', calculo.truncas.toFixed(2), { icono: 'ok', tono: 'exito', detalle: 'proporcionales al año en curso' }]
    ]);
  });
}
