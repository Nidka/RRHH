// Selector de empleado por apellidos, nombres o documento (CR-019).
// Reemplaza el ingreso del código interno: el formulario sigue recibiendo un campo oculto con el código,
// así que las pantallas envían a la API exactamente lo mismo que antes.

import { api } from './api.js';
import { plantilla } from './formulario.js';
import { avatar, chip, icono } from './ui.js';

const MINIMO = 2;
const ESPERA_MS = 250;
let contador = 0;

/**
 * Coloca un selector en el formulario, en lugar del marcador <div data-selector-empleado="nombre">,
 * y lo limpia cuando el formulario se reinicia (reset no vacía los campos ocultos).
 */
export function selectorEnFormulario(formulario, nombre = 'empleado', opciones = {}) {
  const selector = selectorEmpleado({ nombre, ...opciones });
  formulario.querySelector(`[data-selector-empleado="${nombre}"]`).replaceWith(selector.elemento);
  formulario.addEventListener('reset', () => selector.limpiar());
  return selector;
}

/**
 * Crea el selector. opciones: nombre del campo (por defecto 'empleado'), etiqueta y si es obligatorio.
 * Devuelve { elemento, asignar(id, texto), limpiar(), bloquear(si) }.
 */
export function selectorEmpleado({ nombre = 'empleado', etiqueta = 'Empleado', requerido = true } = {}) {
  const id = `selector-empleado-${++contador}`;
  const fragmento = plantilla(`
    <div class="selector-empleado">
      <label for="${id}"></label>
      <div class="selector-caja">
        <input id="${id}" type="search" role="combobox" autocomplete="off" spellcheck="false"
               aria-autocomplete="list" aria-expanded="false" aria-controls="${id}-lista"
               placeholder="Apellidos, nombres o documento">
      </div>
      <input type="hidden">
      <ul id="${id}-lista" role="listbox" hidden></ul>
      <small class="ayuda" id="${id}-ayuda" aria-live="polite"></small>
    </div>`);
  const elemento = fragmento.firstElementChild;
  const [rotulo, texto, oculto, lista, ayuda] =
    ['label', 'input[type=search]', 'input[type=hidden]', 'ul', 'small'].map(s => elemento.querySelector(s));
  rotulo.textContent = requerido ? etiqueta : `${etiqueta} (opcional)`;
  oculto.name = nombre;
  texto.required = requerido;
  texto.setAttribute('aria-describedby', ayuda.id);
  texto.before(icono('buscar'));

  let resultados = [];
  let activo = -1;
  let consultaVigente = 0;
  let espera;

  const validar = () => texto.setCustomValidity(
    texto.value.trim() && !oculto.value ? 'Elija un empleado de la lista.' : '');

  function cerrar() {
    lista.hidden = true;
    texto.setAttribute('aria-expanded', 'false');
    texto.removeAttribute('aria-activedescendant');
    activo = -1;
  }

  function elegir(empleado) {
    oculto.value = empleado.idEmpleado;
    texto.value = empleado.nombreCompleto;
    ayuda.textContent = `Código ${empleado.idEmpleado}` + (empleado.documento ? ` · documento ${empleado.documento}` : '')
      + (empleado.activo ? '' : ' · cesado');
    validar();
    cerrar();
    oculto.dispatchEvent(new Event('change', { bubbles: true }));
  }

  function marcar(indice) {
    const opcionesLista = lista.querySelectorAll('[role=option]');
    opcionesLista.forEach((opcion, i) => opcion.setAttribute('aria-selected', String(i === indice)));
    activo = indice;
    if (indice >= 0) {
      texto.setAttribute('aria-activedescendant', opcionesLista[indice].id);
      opcionesLista[indice].scrollIntoView({ block: 'nearest' });
    }
  }

  function dibujar() {
    lista.replaceChildren();
    if (!resultados.length) {
      const vacio = document.createElement('li');
      vacio.className = 'sin-resultados';
      vacio.textContent = 'No se encontraron empleados.';
      lista.append(vacio);
    }
    resultados.forEach((empleado, i) => {
      const opcion = document.createElement('li');
      opcion.id = `${id}-opcion-${i}`;
      opcion.setAttribute('role', 'option');
      const nombreVisible = empleado.nombreCompleto || `Empleado ${empleado.idEmpleado}`;
      const bloque = document.createElement('div');
      const nombreFuerte = document.createElement('b');
      nombreFuerte.textContent = nombreVisible;
      const detalle = document.createElement('small');
      detalle.textContent = [empleado.documento && `DNI ${empleado.documento}`, `código ${empleado.idEmpleado}`].filter(Boolean).join(' · ');
      bloque.append(nombreFuerte, detalle);
      const estado = chip(empleado.activo ? 'Activo' : 'Cesado', empleado.activo ? 'exito' : 'peligro');
      estado.style.marginLeft = 'auto';
      opcion.append(avatar(nombreVisible, empleado.idEmpleado), bloque, estado);
      opcion.addEventListener('mousedown', evento => { evento.preventDefault(); elegir(empleado); });
      lista.append(opcion);
    });
    lista.hidden = false;
    texto.setAttribute('aria-expanded', 'true');
    marcar(resultados.length ? 0 : -1);
  }

  async function buscar() {
    const valor = texto.value.trim();
    if (valor.length < MINIMO) { cerrar(); return; }
    const numero = ++consultaVigente;
    try {
      const encontrados = await api('empleados?texto=' + encodeURIComponent(valor));
      if (numero !== consultaVigente || document.activeElement !== texto) return;
      resultados = encontrados;
      dibujar();
    } catch (falla) {
      if (numero === consultaVigente) ayuda.textContent = falla.message;
    }
  }

  texto.addEventListener('input', () => {
    oculto.value = '';
    ayuda.textContent = texto.value.trim().length && texto.value.trim().length < MINIMO ? 'Escriba al menos 2 caracteres.' : '';
    validar();
    clearTimeout(espera);
    espera = setTimeout(buscar, ESPERA_MS);
  });
  texto.addEventListener('keydown', evento => {
    if (lista.hidden) {
      if (evento.key === 'ArrowDown') buscar();
      return;
    }
    if (evento.key === 'ArrowDown') { evento.preventDefault(); marcar(Math.min(activo + 1, resultados.length - 1)); }
    else if (evento.key === 'ArrowUp') { evento.preventDefault(); marcar(Math.max(activo - 1, 0)); }
    else if (evento.key === 'Enter' && activo >= 0) { evento.preventDefault(); elegir(resultados[activo]); }
    else if (evento.key === 'Escape') { evento.preventDefault(); cerrar(); }
  });
  texto.addEventListener('blur', () => setTimeout(cerrar, 100));

  return {
    elemento,
    /** Fija un empleado conocido (por ejemplo, al cargar un registro existente). */
    asignar(idEmpleado, nombreVisible) {
      elegir({ idEmpleado, nombreCompleto: nombreVisible || `Empleado ${idEmpleado}`, activo: true });
    },
    limpiar() {
      oculto.value = '';
      texto.value = '';
      ayuda.textContent = '';
      validar();
      cerrar();
    },
    /** Impide cambiar el empleado, como al editar un registro que ya le pertenece. */
    bloquear(si) { texto.readOnly = si; }
  };
}
