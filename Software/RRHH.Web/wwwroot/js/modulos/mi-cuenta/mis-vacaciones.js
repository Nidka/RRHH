// RF-12: el empleado consulta sus propias vacaciones pendientes y usadas.
// El servidor resuelve el empleado desde la sesión: esta pantalla no envía ningún código de empleado.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { hoy, mostrarFecha } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta">
      <label>Fecha de corte<input name="corte" type="date" required></label>
      <div class="acciones"><button>Consultar mis vacaciones</button></div>
    </form>
    <div class="indicadores"></div>
    <h2>Vacaciones usadas</h2>
    <div class="resultados"></div>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const detalle = contenedor.querySelector('.resultados');
  valores(formulario, { corte: hoy() });

  alEnviar(formulario, async datos => {
    resumen.replaceChildren();
    detalle.replaceChildren();
    const saldo = await api('mi/vacaciones?' + consulta(datos));
    indicadores(resumen, [['Generadas', saldo.generadas], ['Usadas', saldo.usadas], ['Pendientes', saldo.pendientes]]);
    tabla(detalle, ['Permiso', 'Desde', 'Hasta', 'Días'],
      saldo.consumos.map(c => [c.numero, mostrarFecha(c.desde), mostrarFecha(c.hasta), c.dias]),
      'Todavía no tiene vacaciones usadas hasta esta fecha.');
  });

  formulario.requestSubmit();
}
