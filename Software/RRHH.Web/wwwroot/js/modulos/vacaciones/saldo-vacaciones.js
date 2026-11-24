// RF-08: vacaciones pendientes de goce (generadas menos consumos aprobados) y su detalle.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { hoy, mostrarFecha } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta">
      <div data-selector-empleado="empleado"></div>
      <label>Fecha de corte<input name="corte" type="date" required></label>
      <div class="acciones"><button>Consultar pendientes</button></div>
    </form>
    <div class="indicadores"></div>
    <h2>Consumos aprobados</h2>
    <div class="resultados"></div>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const detalle = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario);
  valores(formulario, { corte: hoy() });

  alEnviar(formulario, async datos => {
    resumen.replaceChildren();
    detalle.replaceChildren();
    const saldo = await api('vacaciones/saldo?' + consulta(datos));
    indicadores(resumen, [['Generadas', saldo.generadas], ['Usadas', saldo.usadas], ['Pendientes de goce', saldo.pendientes]]);
    tabla(detalle, ['Permiso', 'Desde', 'Hasta', 'Días'],
      saldo.consumos.map(c => [c.numero, mostrarFecha(c.desde), mostrarFecha(c.hasta), c.dias]),
      'Sin consumos aprobados hasta el corte.');
  });
}
