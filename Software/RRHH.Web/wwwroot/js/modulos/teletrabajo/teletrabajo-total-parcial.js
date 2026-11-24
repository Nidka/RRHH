// RF-16: quiénes realizan teletrabajo total o parcial en un periodo.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores } from '../../componentes/formulario.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { hoy, inicioDeMes } from '../../componentes/fechas.js';

const TOTAL = 0;

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta">
      <label>Desde<input type="date" name="desde" required></label>
      <label>Hasta<input type="date" name="hasta" required></label>
      <label>Clasificación<select name="clase"><option value="">Todas</option><option value="T">Total</option><option value="P">Parcial</option></select></label>
      <div class="acciones"><button>Consultar personal</button></div>
    </form>
    <p class="nota">Total: teletrabaja todos los días laborables del periodo. Parcial: solo algunos.</p>
    <div class="indicadores"></div>
    <div class="resultados"></div>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const resultados = contenedor.querySelector('.resultados');
  valores(formulario, { desde: inicioDeMes(), hasta: hoy() });

  alEnviar(formulario, async datos => {
    resumen.replaceChildren();
    resultados.replaceChildren();
    const filas = await api('clasificacion-teletrabajo?' + consulta(datos));
    const totales = filas.filter(f => f.clasificacion === TOTAL).length;
    indicadores(resumen, [['Personas', filas.length], ['Total', totales], ['Parcial', filas.length - totales]]);
    tabla(resultados, ['Código de empleado', 'Clasificación', 'Días remotos', 'Días laborables'], filas.map(f => [
      f.idEmpleado, f.clasificacion === TOTAL ? 'Total' : 'Parcial', f.diasRemotos, f.diasLaborables
    ]), 'Nadie realiza teletrabajo en el periodo consultado.');
  });
}
