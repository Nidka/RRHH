// Comportamiento común de los formularios y armado seguro de vistas.

import { mostrar, limpiar } from './mensajes.js';

/**
 * Crea nodos a partir de una plantilla HTML fija escrita en el código.
 * Nunca recibe datos del servidor ni del usuario: esos se asignan después con textContent o value.
 */
export function plantilla(html) {
  const elemento = document.createElement('template');
  elemento.innerHTML = html.trim();
  return elemento.content;
}

/**
 * Conecta el envío de un formulario: evita el envío nativo, desactiva el botón mientras trabaja,
 * limpia el mensaje anterior y muestra el error de la operación si ocurre.
 */
export function alEnviar(formulario, ejecutar) {
  formulario.addEventListener('submit', async evento => {
    evento.preventDefault();
    const boton = evento.submitter ?? formulario.querySelector('button:not([type=button])');
    if (boton) boton.disabled = true;
    formulario.setAttribute('aria-busy', 'true');
    limpiar();
    try {
      await ejecutar(new FormData(formulario));
    } catch (falla) {
      mostrar(falla.message, 'error');
    } finally {
      if (boton) boton.disabled = false;
      formulario.removeAttribute('aria-busy');
    }
  });
}

/** Asigna valores iniciales a los campos que existan en el formulario. */
export function valores(formulario, campos) {
  for (const [nombre, valor] of Object.entries(campos)) {
    const campo = formulario.elements[nombre];
    if (campo) campo.value = valor;
  }
}

/** Llena un <select> conservando su primera opción (la de «Seleccione…» o «Todos»). */
export function opciones(select, filas, texto = f => f.descripcion, valor = f => f.id) {
  select.length = 1;
  for (const fila of filas) select.add(new Option(texto(fila), valor(fila)));
}
