// RF-01: asignar un turno a un empleado por un periodo de fechas, y editar sus asignaciones.

import { api } from '../../componentes/api.js';
import { plantilla, alEnviar, opciones } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { tabla } from '../../componentes/tabla.js';
import { exito, mostrar } from '../../componentes/mensajes.js';
import { mostrarFecha, paraCampo } from '../../componentes/fechas.js';

export async function montar(contenedor) {
  contenedor.append(plantilla(`
    <p class="nota">Para el personal con turnos rotativos. Quien trabaja siempre en el mismo turno no necesita asignaciones por periodo.</p>
    <form class="tarjeta">
      <input name="numero" type="hidden" value="0">
      <div data-selector-empleado="empleado"></div>
      <label>Turno<select name="horario" required><option value="">Seleccione un turno</option></select></label>
      <label>Desde<input name="desde" type="date" required></label>
      <label>Hasta<input name="hasta" type="date" required></label>
      <label>Documento de sustento (opcional)<input name="documento" maxlength="50"></label>
      <label>Sisgedo (opcional)<input name="sisgedo" maxlength="50"></label>
      <div class="acciones">
        <button>Registrar turno</button>
        <button type="button" class="secundario" data-nuevo hidden>Nueva asignación</button>
      </div>
    </form>
    <p class="estado" role="status"></p>
    <h2>Asignaciones del empleado</h2>
    <div class="resultados"><p class="vacio">Elija un empleado para ver sus asignaciones.</p></div>`));
  const formulario = contenedor.querySelector('form');
  const estado = contenedor.querySelector('.estado');
  const listado = contenedor.querySelector('.resultados');
  const guardar = formulario.querySelector('button:not([type=button])');
  const nuevo = formulario.querySelector('[data-nuevo]');
  const empleado = selectorEnFormulario(formulario);

  // Vuelve al alta conservando el empleado elegido.
  function modoNuevo() {
    for (const campo of ['horario', 'desde', 'hasta', 'documento', 'sisgedo']) formulario.elements[campo].value = '';
    formulario.elements.numero.value = '0';
    empleado.bloquear(false);
    guardar.textContent = 'Registrar turno';
    nuevo.hidden = true;
    estado.textContent = '';
  }

  async function editar(numero) {
    const asignacion = await api(`horarios/asignaciones/${formulario.elements.empleado.value}/${numero}`);
    formulario.elements.numero.value = asignacion.numero;
    formulario.elements.horario.value = asignacion.idHorario;
    formulario.elements.desde.value = paraCampo(asignacion.desde);
    formulario.elements.hasta.value = paraCampo(asignacion.hasta);
    formulario.elements.documento.value = asignacion.documento ?? '';
    formulario.elements.sisgedo.value = asignacion.sisgedo ?? '';
    empleado.bloquear(true);
    guardar.textContent = 'Guardar cambios';
    nuevo.hidden = false;
    estado.textContent = `Editando la asignación ${asignacion.numero}.`;
    formulario.elements.horario.focus();
  }

  async function listar() {
    const id = formulario.elements.empleado.value;
    if (!id) { listado.replaceChildren(); return; }
    const filas = await api('horarios/historico?empleado=' + encodeURIComponent(id));
    tabla(listado, ['N.º', 'Desde', 'Hasta', 'Turno', 'Documento', ''], filas.map(fila => {
      const boton = document.createElement('button');
      boton.type = 'button';
      boton.className = 'secundario';
      boton.textContent = 'Editar';
      boton.addEventListener('click', () => editar(fila.n).catch(falla => mostrar(falla.message, 'error')));
      return [fila.n, mostrarFecha(fila.fechaInicio), mostrarFecha(fila.fechaFin), fila.descrip_Horario, fila.nroDocumento ?? '', boton];
    }), 'El empleado no tiene asignaciones por periodo: trabaja en su turno estable.');
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

  opciones(formulario.elements.horario, await api('horarios/catalogo'));
}
