// CR-020: alta y edición de empleados desde la web (datos básicos, área, ingreso y estado).

import { api } from '../../componentes/api.js';
import { plantilla, alEnviar, opciones, valores } from '../../componentes/formulario.js';
import { selectorEmpleado } from '../../componentes/selector-empleado.js';
import { chip, persona, vacio } from '../../componentes/ui.js';
import { exito, mostrar } from '../../componentes/mensajes.js';
import { hoy, mostrarFecha, paraCampo } from '../../componentes/fechas.js';

export async function montar(contenedor) {
  contenedor.append(plantilla(`
    <div class="rejilla formulario-y-resultado">
      <div>
        <div class="tarjeta formulario" data-buscar>
          <div data-lugar-selector class="completo"></div>
          <div class="acciones"><button type="button" class="btn" data-nuevo>Registrar uno nuevo</button></div>
        </div>
        <form class="tarjeta formulario separado-chico">
          <h2 class="completo" data-titulo>Nuevo empleado</h2>
          <label>Tipo de documento<select name="tipoDocumento" required><option value="">Seleccione</option></select></label>
          <label>Número de documento<input name="numeroDocumento" maxlength="12" required autocomplete="off"
                 pattern="[A-Za-z0-9\\-]+" title="Letras, números o guion" placeholder="Ej. 40000001"></label>
          <label>Apellido paterno<input name="apellidoPaterno" maxlength="30" required autocomplete="off"></label>
          <label>Apellido materno <small>(opcional)</small><input name="apellidoMaterno" maxlength="30" autocomplete="off"></label>
          <label class="completo">Nombres<input name="nombres" maxlength="100" required autocomplete="off"></label>
          <label>Área<select name="area" required><option value="">Seleccione un área</option></select></label>
          <label>Fecha de ingreso<input name="fechaIngreso" type="date" required></label>
          <label class="completo" data-estado hidden>Estado<select name="activo">
            <option value="true">Activo</option><option value="false">Cesado</option></select></label>
          <div class="acciones"><button class="btn btn-primario" data-guardar>Registrar empleado</button></div>
        </form>
      </div>
      <section class="tarjeta">
        <div class="tarjeta-cabecera"><div><h2>Ficha</h2><p data-anio></p></div></div>
        <div class="resultados separado-chico"></div>
      </section>
    </div>`));

  const formulario = contenedor.querySelector('form');
  const titulo = contenedor.querySelector('[data-titulo]');
  const guardar = contenedor.querySelector('[data-guardar]');
  const estado = contenedor.querySelector('[data-estado]');
  const ficha = contenedor.querySelector('.resultados');
  const selector = selectorEmpleado({ nombre: 'editar', etiqueta: 'Buscar un empleado para editarlo', requerido: false });
  contenedor.querySelector('[data-lugar-selector]').replaceWith(selector.elemento);

  const datos = await api('personal/catalogos');
  opciones(formulario.elements.tipoDocumento, datos.tiposDocumento);
  opciones(formulario.elements.area, datos.areas);
  contenedor.querySelector('[data-anio]').textContent =
    `Las altas se registran en ${datos.anio}. Luego el empleado ya puede elegirse en turnos, permisos y vacaciones.`;
  let editando = 0;

  function mostrarFicha(empleado) {
    const nombre = [empleado.apellidoPaterno, empleado.apellidoMaterno].filter(Boolean).join(' ') + ', ' + empleado.nombres;
    const area = datos.areas.find(a => a.id === empleado.area);
    const lista = document.createElement('dl');
    lista.className = 'ficha-datos';
    for (const [rotulo, valor] of [
      ['Documento', empleado.numeroDocumento],
      ['Área', area ? area.descripcion : `Área ${empleado.area}`],
      ['Ingreso', mostrarFecha(empleado.fechaIngreso)],
      ['Año del registro', String(empleado.anio)]]) {
      const dt = document.createElement('dt'); dt.textContent = rotulo;
      const dd = document.createElement('dd'); dd.textContent = valor;
      lista.append(dt, dd);
    }
    ficha.replaceChildren(persona(nombre, `código ${empleado.id}`, empleado.id),
      chip(empleado.activo ? 'Activo' : 'Cesado', empleado.activo ? 'exito' : 'aviso'), lista);
  }

  function modoAlta() {
    editando = 0;
    formulario.reset();
    selector.limpiar();
    valores(formulario, { fechaIngreso: hoy() });
    titulo.textContent = 'Nuevo empleado';
    guardar.textContent = 'Registrar empleado';
    estado.hidden = true;
    ficha.replaceChildren(vacio('Complete el formulario para registrar a una persona, o busque a alguien para editarlo.', 'personas'));
  }

  async function cargar(id) {
    const empleado = await api('personal/empleados/' + encodeURIComponent(id));
    editando = empleado.id;
    valores(formulario, {
      tipoDocumento: empleado.tipoDocumento || '', numeroDocumento: empleado.numeroDocumento || '',
      apellidoPaterno: empleado.apellidoPaterno || '', apellidoMaterno: empleado.apellidoMaterno || '',
      nombres: empleado.nombres || '', area: empleado.area, fechaIngreso: paraCampo(empleado.fechaIngreso),
      activo: String(empleado.activo)
    });
    if (!datos.areas.some(a => a.id === empleado.area)) {
      formulario.elements.area.value = '';
      mostrar(`El área ${empleado.area} no está en la estructura de ${datos.anio}. Elija una antes de guardar.`, 'info');
    }
    titulo.textContent = `Editar empleado ${empleado.id}`;
    guardar.textContent = 'Guardar cambios';
    estado.hidden = false;
    mostrarFicha(empleado);
  }

  selector.elemento.querySelector('input[type=hidden]').addEventListener('change', evento => {
    if (evento.target.value) cargar(evento.target.value).catch(falla => mostrar(falla.message, 'error'));
  });
  contenedor.querySelector('[data-nuevo]').addEventListener('click', modoAlta);

  alEnviar(formulario, async valoresFormulario => {
    const entrada = Object.fromEntries(valoresFormulario);
    entrada.tipoDocumento = Number(entrada.tipoDocumento);
    entrada.area = Number(entrada.area);
    entrada.activo = editando ? entrada.activo === 'true' : true;
    if (editando) {
      const guardado = await api('personal/empleados/' + editando, entrada);
      exito(`Empleado ${guardado.id} actualizado.`);
      mostrarFicha(guardado);
    } else {
      const creado = await api('personal/empleados', entrada);
      exito(`Empleado ${creado.id} registrado.`);
      // Al fijarlo en el buscador se dispara su carga y el formulario queda en modo edición.
      selector.asignar(creado.id, [creado.apellidoPaterno, creado.apellidoMaterno].filter(Boolean).join(' ') + ', ' + creado.nombres);
    }
  });

  modoAlta();
}
