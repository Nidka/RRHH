// RF-13: registrar periodos de teletrabajo (total o parcial con días remotos) y ver los vigentes del empleado.

import { api } from '../../componentes/api.js';
import { plantilla, alEnviar } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla } from '../../componentes/tabla.js';
import { exito, mostrar } from '../../componentes/mensajes.js';
import { mostrarFecha } from '../../componentes/fechas.js';

const TODOS_LOS_DIAS = 31; // lunes a viernes: 1 + 2 + 4 + 8 + 16
const DIAS = ['Lun', 'Mar', 'Mié', 'Jue', 'Vie'];

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <form class="tarjeta">
      <div data-selector-empleado="empleado"></div>
      <label>Modalidad<select name="modalidad"><option value="T">Total</option><option value="P">Parcial</option></select></label>
      <label>Desde<input type="date" name="desde" required></label>
      <label>Hasta<input type="date" name="hasta" required></label>
      <fieldset data-patron hidden><legend>Días remotos</legend>
        <label><input type="checkbox" name="dia" value="1">Lunes</label>
        <label><input type="checkbox" name="dia" value="2">Martes</label>
        <label><input type="checkbox" name="dia" value="4">Miércoles</label>
        <label><input type="checkbox" name="dia" value="8">Jueves</label>
        <label><input type="checkbox" name="dia" value="16">Viernes</label>
      </fieldset>
      <label class="completo">Referencia de autorización (opcional)<input name="autorizacion" maxlength="200"></label>
      <div class="acciones"><button>Registrar periodo</button></div>
    </form>
    <h2>Periodos vigentes del empleado</h2>
    <div class="resultados"><p class="vacio">Elija un empleado para ver sus periodos.</p></div>`));
  const formulario = contenedor.querySelector('form');
  const patron = formulario.querySelector('[data-patron]');
  const listado = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario);

  async function listar() {
    const id = formulario.elements.empleado.value;
    if (!id) { listado.replaceChildren(); return; }
    const filas = await api('periodos?empleado=' + encodeURIComponent(id));
    tabla(listado, ['Código', 'Desde', 'Hasta', 'Modalidad', 'Días remotos', 'Autorización'], filas.map(f => [
      f.id, mostrarFecha(f.desde), mostrarFecha(f.hasta), f.modalidad === 0 ? 'Total' : 'Parcial',
      DIAS.filter((_, i) => f.diasRemotos & (1 << i)).join(', '), f.autorizacion ?? ''
    ]), 'El empleado no tiene periodos de teletrabajo vigentes.');
  }

  formulario.elements.modalidad.addEventListener('change', () => {
    patron.hidden = formulario.elements.modalidad.value !== 'P';
  });
  formulario.addEventListener('change', evento => {
    if (evento.target.name === 'empleado') listar().catch(falla => mostrar(falla.message, 'error'));
  });

  alEnviar(formulario, async datos => {
    const entrada = Object.fromEntries(datos);
    delete entrada.dia;
    entrada.empleado = Number(entrada.empleado);
    entrada.diasRemotos = entrada.modalidad === 'T'
      ? TODOS_LOS_DIAS
      : datos.getAll('dia').reduce((suma, dia) => suma | Number(dia), 0);
    const registro = await api('periodos', entrada);
    exito(`Periodo registrado con código ${registro.id}.`);
    await listar();
  });
}
