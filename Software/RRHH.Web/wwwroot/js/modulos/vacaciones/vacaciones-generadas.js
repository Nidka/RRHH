// RF-07: cálculo de vacaciones generadas por aniversarios cumplidos al corte.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { indicadores } from '../../componentes/tabla.js';
import { hoy, mostrarFecha } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <div data-selector-empleado="empleado"></div>
      <label>Fecha de corte<input name="corte" type="date" required></label>
      <div class="acciones"><button class="btn btn-primario">Calcular</button></div>
    </form>
    <p class="nota separado"><svg class="icono"><use href="#i-info"/></svg><span>Se generan los días del régimen por cada aniversario completo desde la fecha de ingreso hasta el corte.</span></p>
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
      ['Años cumplidos', fila.aniosCumplidos, { icono: 'calendario', tono: 'cian' }],
      ['Días por año', fila.diasAnuales, { icono: 'vacaciones' }],
      ['Días generados', fila.generadas, { icono: 'ok', tono: 'exito', detalle: `${fila.aniosCumplidos} × ${fila.diasAnuales} días` }]
    ]);
  });
}
