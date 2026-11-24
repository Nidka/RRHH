// RF-13: registrar periodos de teletrabajo (total o parcial con días remotos) y ver los vigentes del empleado.

import { api } from '../../componentes/api.js';
import { plantilla, alEnviar } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla } from '../../componentes/tabla.js';
import { lineaTiempo } from '../../componentes/graficos.js';
import { chip, vacio } from '../../componentes/ui.js';
import { exito, mostrar } from '../../componentes/mensajes.js';
import { mostrarFecha } from '../../componentes/fechas.js';

const TODOS_LOS_DIAS = 31; // lunes a viernes: 1 + 2 + 4 + 8 + 16
const DIAS = ['Lun', 'Mar', 'Mié', 'Jue', 'Vie'];

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <div class="rejilla formulario-y-resultado">
      <form class="tarjeta formulario">
        <div data-selector-empleado="empleado"></div>
        <fieldset><legend>Modalidad</legend>
          <div class="pastillas">
            <label class="pastilla"><input type="radio" name="modalidad" value="T" checked><span>Total · todos los días</span></label>
            <label class="pastilla"><input type="radio" name="modalidad" value="P"><span>Parcial · algunos días</span></label>
          </div>
        </fieldset>
        <label>Desde<input type="date" name="desde" required></label>
        <label>Hasta<input type="date" name="hasta" required></label>
        <fieldset data-patron hidden><legend>Días remotos</legend>
          <div class="pastillas">
            <label class="pastilla"><input type="checkbox" name="dia" value="1"><span>Lunes</span></label>
            <label class="pastilla"><input type="checkbox" name="dia" value="2"><span>Martes</span></label>
            <label class="pastilla"><input type="checkbox" name="dia" value="4"><span>Miércoles</span></label>
            <label class="pastilla"><input type="checkbox" name="dia" value="8"><span>Jueves</span></label>
            <label class="pastilla"><input type="checkbox" name="dia" value="16"><span>Viernes</span></label>
          </div>
        </fieldset>
        <label class="completo">Referencia de autorización <small>(opcional)</small><input name="autorizacion" maxlength="200"></label>
        <div class="acciones"><button class="btn btn-primario">Registrar periodo</button></div>
      </form>
      <section class="tarjeta">
        <div class="tarjeta-cabecera"><div><h2>Periodos vigentes</h2><p>No se admiten periodos que se solapen para la misma persona.</p></div></div>
        <div data-linea></div>
        <div class="resultados separado-chico"></div>
      </section>
    </div>`));
  const formulario = contenedor.querySelector('form');
  const patron = formulario.querySelector('[data-patron]');
  const linea = contenedor.querySelector('[data-linea]');
  const listado = contenedor.querySelector('.resultados');
  selectorEnFormulario(formulario);
  listado.append(vacio('Elija un empleado para ver sus periodos.', 'teletrabajo'));

  async function listar() {
    const id = formulario.elements.empleado.value;
    linea.replaceChildren();
    if (!id) { listado.replaceChildren(vacio('Elija un empleado para ver sus periodos.', 'teletrabajo')); return; }
    const filas = await api('periodos?empleado=' + encodeURIComponent(id));
    lineaTiempo(linea, filas.map(f => ({ desde: f.desde, hasta: f.hasta, texto: f.modalidad === 0 ? 'Total' : 'Parcial',
      color: f.modalidad === 0 ? '#5b5bf6' : '#22c3e6' })));
    tabla(listado, ['Código', 'Periodo', 'Modalidad', 'Días remotos', 'Autorización'], filas.map(f => [
      f.id, `${mostrarFecha(f.desde)} – ${mostrarFecha(f.hasta)}`, chip(f.modalidad === 0 ? 'Total' : 'Parcial', f.modalidad === 0 ? 'marca' : 'cian'),
      DIAS.filter((_, i) => f.diasRemotos & (1 << i)).join(', '), f.autorizacion || '—'
    ]), 'El empleado no tiene periodos de teletrabajo vigentes.');
  }

  formulario.addEventListener('change', evento => {
    if (evento.target.name === 'modalidad') patron.hidden = formulario.elements.modalidad.value !== 'P';
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
