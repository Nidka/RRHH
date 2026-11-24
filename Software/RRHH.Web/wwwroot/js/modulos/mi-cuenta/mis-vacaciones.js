// RF-12: el empleado consulta sus propias vacaciones pendientes y usadas.
// El servidor resuelve el empleado desde la sesión: esta pantalla no envía ningún código de empleado.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { progreso } from '../../componentes/graficos.js';
import { chip } from '../../componentes/ui.js';
import { hoy, mostrarFecha } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <label>Fecha de corte<input name="corte" type="date" required></label>
      <div class="acciones"><button class="btn btn-primario">Consultar mis vacaciones</button></div>
    </form>
    <div class="indicadores separado"></div>
    <section class="tarjeta">
      <div class="tarjeta-cabecera"><div><h2>Uso de mis vacaciones</h2><p>Días usados frente a días generados al corte.</p></div></div>
      <div data-progreso></div>
    </section>
    <section class="tarjeta sin-relleno">
      <div class="tarjeta-cabecera"><div><h2>Vacaciones usadas</h2><p>Permisos de vacaciones aprobados.</p></div></div>
      <div class="resultados separado-chico"></div>
    </section>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const barra = contenedor.querySelector('[data-progreso]');
  const detalle = contenedor.querySelector('.resultados');
  valores(formulario, { corte: hoy() });

  alEnviar(formulario, async datos => {
    const saldo = await api('mi/vacaciones?' + consulta(datos));
    indicadores(resumen, [
      ['Generadas', saldo.generadas, { icono: 'vacaciones' }],
      ['Usadas', saldo.usadas, { icono: 'calendario', tono: 'aviso' }],
      ['Pendientes', saldo.pendientes, { icono: 'ok', tono: 'exito' }]
    ]);
    barra.replaceChildren(progreso(saldo.usadas, saldo.generadas, `${saldo.usadas} de ${saldo.generadas} días usados`));
    tabla(detalle, ['Permiso', 'Desde', 'Hasta', 'Días'],
      saldo.consumos.map(c => [c.numero, mostrarFecha(c.desde), mostrarFecha(c.hasta), c.dias === 0.5 ? chip('Media jornada', 'cian') : c.dias]),
      'Todavía no tiene vacaciones usadas hasta esta fecha.');
  });

  formulario.requestSubmit();
}
