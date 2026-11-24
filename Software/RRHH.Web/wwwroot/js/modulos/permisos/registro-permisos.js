// RF-03 (sin dos permisos el mismo día), RF-06 (licencia anual única) y RF-10 (media jornada de vacaciones).
// Las validaciones las aplica el servidor dentro de una transacción; aquí solo se capturan y muestran.

import { api, consulta } from '../../componentes/api.js';
import { plantilla, alEnviar } from '../../componentes/formulario.js';
import { selectorEnFormulario } from '../../componentes/selector-empleado.js';
import { exito } from '../../componentes/mensajes.js';
import { paraCampo } from '../../componentes/fechas.js';

const CAMPOS_TEXTO = ['estado', 'lugar', 'referencia', 'autorizacion', 'observacion'];
const CAMPOS_MARCA = ['dia', 'retorno', 'mediaJornadaVacaciones'];

export function montar(contenedor) {
  contenedor.append(plantilla(`
    <ul class="nota">
      <li>No se registran dos permisos de la misma persona en fechas que se solapan.</li>
      <li>Una licencia marcada «una vez por año» se rechaza si ya existe otra en el mismo año.</li>
      <li>Solicitado y Aprobado reservan fechas y cupo anual; Rechazado y Anulado los liberan.</li>
      <li>Una salida autorizada requiere una marcación de hoy sin salida registrada y la fecha de hoy.</li>
    </ul>
    <form class="tarjeta" data-formulario="guardar">
      <input name="numero" type="hidden" value="0">
      <div data-selector-empleado="idEmpleado"></div>
      <label>Código de motivo<input name="idMotivo" type="number" min="1" max="2147483647" required></label>
      <label>Desde<input name="desde" type="date" required></label>
      <label>Hasta<input name="hasta" type="date" required></label>
      <label>Estado<select name="estado"><option>Solicitado</option><option>Aprobado</option><option>Rechazado</option><option>Anulado</option></select></label>
      <label>Lugar (opcional)<input name="lugar" maxlength="20"></label>
      <label>Referencia (opcional)<input name="referencia" maxlength="100"></label>
      <label>Autorización (opcional)<input name="autorizacion" maxlength="50"></label>
      <label class="completo">Observación (opcional)<input name="observacion" maxlength="200"></label>
      <fieldset><legend>Condiciones</legend>
        <label><input name="dia" type="checkbox">Día completo</label>
        <label><input name="retorno" type="checkbox">Con retorno</label>
        <label><input name="mediaJornadaVacaciones" type="checkbox">Media jornada de vacaciones (0,5 días)</label>
      </fieldset>
      <div class="acciones">
        <button>Guardar permiso</button>
        <button type="button" class="secundario" data-nuevo>Nuevo permiso</button>
      </div>
    </form>
    <p class="estado" role="status">Nuevo permiso</p>
    <details class="tarjeta">
      <summary>Editar un permiso existente</summary>
      <form data-formulario="cargar">
        <div data-selector-empleado="empleado"></div>
        <label>Número de permiso<input name="numero" type="number" min="1" max="2147483647" required></label>
        <div class="acciones"><button>Cargar permiso</button></div>
      </form>
    </details>`));
  const guardar = contenedor.querySelector('[data-formulario=guardar]');
  const cargar = contenedor.querySelector('[data-formulario=cargar]');
  const estado = contenedor.querySelector('.estado');
  const empleadoPermiso = selectorEnFormulario(guardar, 'idEmpleado');
  const empleadoBusqueda = selectorEnFormulario(cargar);

  function nuevoPermiso() {
    guardar.reset();
    guardar.elements.numero.value = '0';
    empleadoPermiso.bloquear(false);
    estado.textContent = 'Nuevo permiso';
  }
  guardar.querySelector('[data-nuevo]').addEventListener('click', nuevoPermiso);

  alEnviar(cargar, async datos => {
    const permiso = await api('permisos?' + consulta(datos));
    nuevoPermiso();
    guardar.elements.numero.value = permiso.numero;
    empleadoPermiso.asignar(permiso.idEmpleado, cargar.querySelector('input[type=search]').value);
    empleadoPermiso.bloquear(true);
    guardar.elements.idMotivo.value = permiso.idMotivo ?? '';
    for (const campo of CAMPOS_TEXTO) guardar.elements[campo].value = permiso[campo] ?? '';
    guardar.elements.desde.value = paraCampo(permiso.desde);
    guardar.elements.hasta.value = paraCampo(permiso.hasta);
    for (const campo of CAMPOS_MARCA) guardar.elements[campo].checked = permiso[campo] === true;
    estado.textContent = `Editando el permiso ${permiso.numero}.`;
    guardar.elements.idMotivo.focus();
  });

  alEnviar(guardar, async datos => {
    const entrada = Object.fromEntries(datos);
    for (const campo of ['numero', 'idEmpleado', 'idMotivo']) entrada[campo] = Number(entrada[campo]);
    for (const campo of CAMPOS_MARCA) entrada[campo] = datos.has(campo);
    const resultado = await api('permisos', entrada);
    guardar.elements.numero.value = resultado.numero;
    empleadoPermiso.bloquear(true);
    empleadoBusqueda.asignar(entrada.idEmpleado, guardar.querySelector('input[type=search]').value);
    cargar.elements.numero.value = resultado.numero;
    estado.textContent = `Permiso ${resultado.numero} guardado: ${entrada.estado}.`;
    exito('Permiso guardado correctamente.');
  });
}
