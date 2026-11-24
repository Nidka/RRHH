// RF-01: asignar un turno a un empleado por un periodo de fechas, y editar sus asignaciones.

import { api } from '../../componentes/api.js';
import { plantilla, alEnviar } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla } from '../../componentes/tabla.js';
import { lineaTiempo } from '../../componentes/graficos.js';
import { chip, botonFila, vacio } from '../../componentes/ui.js';
import { exito, mostrar } from '../../componentes/mensajes.js';
import { mostrarFecha, paraCampo } from '../../componentes/fechas.js';

export async function montar(contenedor) {
  contenedor.append(plantilla(`
    <p class="nota"><svg class="icono"><use href="#i-info"/></svg><span>Para el personal con turnos rotativos. Quien trabaja siempre en el mismo turno no necesita asignaciones por periodo.</span></p>
    <div class="rejilla formulario-y-resultado">
      <form class="tarjeta formulario">
        <input name="numero" type="hidden" value="0">
        <div data-selector-empleado="empleado"></div>
        <fieldset class="completo"><legend>Turno</legend><div class="opciones-tarjeta" data-turnos></div></fieldset>
        <label>Desde<input name="desde" type="date" required></label>
        <label>Hasta<input name="hasta" type="date" required></label>
        <label>Documento de sustento <small>(opcional)</small><input name="documento" maxlength="50" placeholder="Memorando, resolución…"></label>
        <label>Sisgedo <small>(opcional)</small><input name="sisgedo" maxlength="50"></label>
        <div class="acciones">
          <button class="btn btn-primario">Registrar turno</button>
          <button type="button" class="btn btn-secundario" data-nuevo hidden>Nueva asignación</button>
        </div>
        <p class="estado completo" role="status"></p>
      </form>
      <section class="tarjeta">
        <div class="tarjeta-cabecera"><div><h2 data-titulo>Asignaciones del empleado</h2><p>Periodos con turno distinto al estable, en orden de fechas.</p></div></div>
        <div data-linea></div>
        <div class="resultados separado-chico"></div>
      </section>
    </div>`));
  const formulario = contenedor.querySelector('form');
  const estado = formulario.querySelector('.estado');
  const titulo = contenedor.querySelector('[data-titulo]');
  const linea = contenedor.querySelector('[data-linea]');
  const listado = contenedor.querySelector('.resultados');
  const guardar = formulario.querySelector('button:not([type=button])');
  const nuevo = formulario.querySelector('[data-nuevo]');
  const empleado = selectorEnFormulario(formulario);
  listado.append(vacio('Elija un empleado para ver sus asignaciones.', 'turnos'));

  // Vuelve al alta conservando el empleado elegido.
  function modoNuevo() {
    for (const campo of ['desde', 'hasta', 'documento', 'sisgedo']) formulario.elements[campo].value = '';
    for (const radio of formulario.querySelectorAll('input[name=horario]')) radio.checked = false;
    formulario.elements.numero.value = '0';
    empleado.bloquear(false);
    guardar.textContent = 'Registrar turno';
    nuevo.hidden = true;
    estado.textContent = '';
  }

  async function editar(numero) {
    const asignacion = await api(`horarios/asignaciones/${formulario.elements.empleado.value}/${numero}`);
    formulario.elements.numero.value = asignacion.numero;
    const radio = formulario.querySelector(`input[name=horario][value="${Number(asignacion.idHorario)}"]`);
    if (radio) radio.checked = true;
    formulario.elements.desde.value = paraCampo(asignacion.desde);
    formulario.elements.hasta.value = paraCampo(asignacion.hasta);
    formulario.elements.documento.value = asignacion.documento ?? '';
    formulario.elements.sisgedo.value = asignacion.sisgedo ?? '';
    empleado.bloquear(true);
    guardar.textContent = 'Guardar cambios';
    nuevo.hidden = false;
    estado.textContent = `Editando la asignación ${asignacion.numero}.`;
    formulario.elements.desde.focus();
  }

  async function listar() {
    const id = formulario.elements.empleado.value;
    linea.replaceChildren();
    if (!id) { titulo.textContent = 'Asignaciones del empleado'; listado.replaceChildren(vacio('Elija un empleado para ver sus asignaciones.', 'turnos')); return; }
    titulo.textContent = `Asignaciones de ${formulario.querySelector('.selector-empleado input[type=search]').value}`;
    const filas = await api('horarios/historico?empleado=' + encodeURIComponent(id));
    lineaTiempo(linea, filas.map(f => ({ desde: f.fechaInicio, hasta: f.fechaFin, texto: `N.º ${f.n} · ${f.descrip_Horario}` })));
    tabla(listado, ['N.º', 'Periodo', 'Turno', 'Sustento', ''], filas.map(f => [
      f.n, `${mostrarFecha(f.fechaInicio)} – ${mostrarFecha(f.fechaFin)}`, chip(f.descrip_Horario, 'marca'), f.nroDocumento || '—',
      botonFila('Editar', () => editar(f.n).catch(falla => mostrar(falla.message, 'error')))
    ]), 'El empleado no tiene asignaciones por periodo: trabaja en su turno estable.');
  }

  formulario.addEventListener('change', evento => {
    if (evento.target.name === 'empleado') { modoNuevo(); listar().catch(falla => mostrar(falla.message, 'error')); }
  });
  nuevo.addEventListener('click', modoNuevo);

  alEnviar(formulario, async datos => {
    const entrada = Object.fromEntries(datos);
    for (const campo of ['empleado', 'numero', 'horario']) entrada[campo] = Number(entrada[campo]);
    const guardado = await api('horarios/asignaciones', entrada);
    modoNuevo();
    exito(`Asignación ${guardado.numero} guardada.`);
    await listar();
  });

  const turnos = formulario.querySelector('[data-turnos]');
  for (const horario of await api('horarios/catalogo')) {
    const opcion = document.createElement('label');
    opcion.className = 'opcion-tarjeta';
    const radio = document.createElement('input');
    radio.type = 'radio';
    radio.name = 'horario';
    radio.value = horario.id;
    radio.required = true;
    const texto = document.createElement('span');
    texto.textContent = horario.descripcion;
    opcion.append(radio, texto);
    turnos.append(opcion);
  }
  if (!turnos.children.length) turnos.append(vacio('No hay turnos registrados en el catálogo.'));
}
