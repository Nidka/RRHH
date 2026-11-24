// RF-07: cálculo de vacaciones generadas por aniversarios cumplidos al corte.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { indicadores } from '../../componentes/tabla.js';
import { hoy, mostrarFecha } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta">
      <div data-selector-empleado="empleado"></div>
      <label>Fecha de corte<input name="corte" type="date" required></label>
      <div class="acciones"><button>Calcular vacaciones generadas</button></div>
    </form>
    <p class="estado" role="status"></p>
    <div class="indicadores"></div>`));
  const formulario = contenedor.querySelector('form');
  const estado = contenedor.querySelector('.estado');
  const resultado = contenedor.querySelector('.indicadores');
  selectorEnFormulario(formulario);
  valores(formulario, { corte: hoy() });

  alEnviar(formulario, async datos => {
    resultado.replaceChildren();
    estado.textContent = '';
    const fila = await api('vacaciones/generadas?' + consulta(datos));
    estado.textContent = `Ingreso ${mostrarFecha(fila.ingreso)} · corte ${mostrarFecha(fila.corte)}`;
    indicadores(resultado, [
      ['Años cumplidos', fila.aniosCumplidos],
      ['Días por año', fila.diasAnuales],
      ['Días generados', fila.generadas]
    ]);
  });
}
