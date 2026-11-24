// RF-16: quiénes realizan teletrabajo total o parcial en un periodo.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores, rangosRapidos } from '../../componentes/formulario.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { dona, progreso } from '../../componentes/graficos.js';
import { nombresDe } from '../../componentes/nombres.js';
import { persona, chip, vacio } from '../../componentes/ui.js';
import { hoy, inicioDeMes } from '../../componentes/fechas.js';

const TOTAL = 0;

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta formulario en-linea">
      <label>Desde<input type="date" name="desde" required></label>
      <label>Hasta<input type="date" name="hasta" required></label>
      <label>Clasificación<select name="clase"><option value="">Todas</option><option value="T">Total</option><option value="P">Parcial</option></select></label>
      <div class="acciones"><button class="btn btn-primario">Consultar personal</button></div>
      <div data-rangos></div>
    </form>
    <div class="indicadores separado"></div>
    <div class="rejilla ancha-angosta">
      <section class="tarjeta sin-relleno">
        <div class="tarjeta-cabecera"><div><h2>Personal en teletrabajo</h2><p>Total: todos los días laborables del periodo. Parcial: solo algunos.</p></div></div>
        <div class="resultados separado-chico"></div>
      </section>
      <section class="tarjeta">
        <div class="tarjeta-cabecera"><div><h2>Modalidad</h2><p>Personas por clasificación.</p></div></div>
        <div data-dona></div>
      </section>
    </div>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const resultados = contenedor.querySelector('.resultados');
  const grafico = contenedor.querySelector('[data-dona]');
  valores(formulario, { desde: inicioDeMes(), hasta: hoy() });
  rangosRapidos(formulario);
  resultados.append(vacio('Elija el periodo y consulte el personal.', 'teletrabajo'));

  alEnviar(formulario, async datos => {
    resultados.replaceChildren();
    const filas = await api('clasificacion-teletrabajo?' + consulta(datos));
    const nombres = await nombresDe(filas.map(f => f.idEmpleado));
    const totales = filas.filter(f => f.clasificacion === TOTAL).length;
    indicadores(resumen, [
      ['Personas en teletrabajo', filas.length, { icono: 'personas' }],
      ['Total', totales, { icono: 'teletrabajo', detalle: 'todos los días laborables' }],
      ['Parcial', filas.length - totales, { icono: 'calendario', tono: 'cian', detalle: 'algunos días' }],
      ['Días laborables', filas[0]?.diasLaborables ?? '—', { icono: 'reportes', tono: 'exito', detalle: 'descontando feriados' }]
    ]);
    dona(grafico, [{ etiqueta: 'Total', valor: totales, color: '#5b5bf6' }, { etiqueta: 'Parcial', valor: filas.length - totales, color: '#22c3e6' }],
      { valor: filas.length, texto: 'personas' });
    tabla(resultados, ['Persona', 'Clasificación', 'Días remotos'], filas.map(f => [
      persona(nombres.get(f.idEmpleado)?.nombreCompleto, `código ${f.idEmpleado}`, f.idEmpleado),
      chip(f.clasificacion === TOTAL ? 'Total' : 'Parcial', f.clasificacion === TOTAL ? 'marca' : 'cian'),
      progreso(f.diasRemotos, f.diasLaborables)
    ]), 'Nadie realiza teletrabajo en el periodo consultado.');
  });
}
