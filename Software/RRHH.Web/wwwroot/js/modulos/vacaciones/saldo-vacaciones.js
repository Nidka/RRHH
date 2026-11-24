// RF-08: vacaciones pendientes de goce (generadas menos consumos aprobados) y su detalle.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { progreso } from '../../componentes/graficos.js';
import { chip, vacio } from '../../componentes/ui.js';
import { hoy, mostrarFecha } from '../../componentes/fechas.js';

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <div data-selector-empleado="empleado"></div>
      <label>Fecha de corte<input name="corte" type="date" required></label>
      <div class="acciones"><button class="btn btn-primario">Consultar pendientes</button></div>
    </form>
    <div class="indicadores separado"></div>
    <section class="tarjeta">
      <div class="tarjeta-cabecera"><div><h2>Uso del saldo</h2><p>Días usados frente a días generados al corte.</p></div></div>
      <div data-progreso></div>
    </section>
    <section class="tarjeta sin-relleno">
      <div class="tarjeta-cabecera"><div><h2>Consumos aprobados</h2><p>Permisos de vacaciones aprobados hasta el corte; la media jornada cuenta 0,5.</p></div></div>
      <div class="resultados separado-chico"></div>
    </section>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const barra = contenedor.querySelector('[data-progreso]');
  const detalle = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario);
  valores(formulario, { corte: hoy() });
  barra.append(vacio('Elija un empleado y consulte su saldo.', 'vacaciones'));

  alEnviar(formulario, async datos => {
    resumen.replaceChildren();
    detalle.replaceChildren();
    barra.replaceChildren();
    const saldo = await api('vacaciones/saldo?' + consulta(datos));
    indicadores(resumen, [
      ['Generadas', saldo.generadas, { icono: 'vacaciones' }],
      ['Usadas', saldo.usadas, { icono: 'calendario', tono: 'aviso' }],
      ['Pendientes de goce', saldo.pendientes, { icono: 'ok', tono: 'exito' }]
    ]);
    barra.append(progreso(saldo.usadas, saldo.generadas, `${saldo.usadas} de ${saldo.generadas} días usados`));
    tabla(detalle, ['Permiso', 'Desde', 'Hasta', 'Días'],
      saldo.consumos.map(c => [c.numero, mostrarFecha(c.desde), mostrarFecha(c.hasta), c.dias === 0.5 ? chip('Media jornada', 'cian') : c.dias]),
      'Sin consumos aprobados hasta el corte.');
  });
}
