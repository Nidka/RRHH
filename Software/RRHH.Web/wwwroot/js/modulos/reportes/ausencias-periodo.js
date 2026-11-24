// RF-18: quiénes están de vacaciones, licencia, enfermedad u otro motivo entre dos fechas.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar, valores, opciones } from '../../componentes/formulario.js';
import { tabla, indicadores } from '../../componentes/tabla.js';
import { hoy, inicioDeMes, mostrarFecha } from '../../componentes/fechas.js';

export async function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta">
      <label>Desde<input type="date" name="desde" required></label>
      <label>Hasta<input type="date" name="hasta" required></label>
      <label>Motivo<select name="motivo"><option value="">Todos los motivos</option></select></label>
      <div class="acciones"><button>Consultar ausencias</button></div>
    </form>
    <p class="nota">Incluye toda ausencia que se cruce con el periodo, aunque empiece antes o termine después. Los permisos anulados no se cuentan.</p>
    <div class="indicadores"></div>
    <div class="resultados"></div>`));
  const formulario = contenedor.querySelector('form');
  const resumen = contenedor.querySelector('.indicadores');
  const resultados = contenedor.querySelector('.resultados');
  valores(formulario, { desde: inicioDeMes(), hasta: hoy() });

  alEnviar(formulario, async datos => {
    resumen.replaceChildren();
    resultados.replaceChildren();
    const filas = await api('ausencias?' + consulta(datos));
    indicadores(resumen, [['Personas', new Set(filas.map(f => f.idEmpleado)).size], ['Ausencias', filas.length]]);
    tabla(resultados, ['Código', 'Persona', 'Motivo', 'Inicio', 'Fin', 'Días en el periodo'], filas.map(f => [
      f.idEmpleado, f.empleado, f.motivo, mostrarFecha(f.inicio), mostrarFecha(f.fin), f.diasEnPeriodo
    ]), 'Nadie se ausenta en el periodo consultado.');
  });

  opciones(formulario.elements.motivo, await api('ausencias/motivos'));
}
