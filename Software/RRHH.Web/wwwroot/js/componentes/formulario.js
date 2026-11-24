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

const iso = d => `${d.getFullYear()}-${String(d.getMonth() + 1).padStart(2, '0')}-${String(d.getDate()).padStart(2, '0')}`;

/**
 * Agrega atajos de periodo («Este mes», «Mes anterior», «Últimos 7 días») que completan los campos
 * desde y hasta del formulario. Se colocan en el marcador <div data-rangos>.
 */
export function rangosRapidos(formulario) {
  const marcador = formulario.querySelector('[data-rangos]');
  if (!marcador) return;
  const hoy = new Date();
  const atajos = [
    ['Este mes', new Date(hoy.getFullYear(), hoy.getMonth(), 1), hoy],
    ['Mes anterior', new Date(hoy.getFullYear(), hoy.getMonth() - 1, 1), new Date(hoy.getFullYear(), hoy.getMonth(), 0)],
    ['Últimos 7 días', new Date(hoy.getFullYear(), hoy.getMonth(), hoy.getDate() - 6), hoy]
  ];
  marcador.className = 'rangos';
  for (const [texto, desde, hasta] of atajos) {
    const boton = document.createElement('button');
    boton.type = 'button';
    boton.textContent = texto;
    boton.addEventListener('click', () => valores(formulario, { desde: iso(desde), hasta: iso(hasta) }));
    marcador.append(boton);
  }
}

/** Llena un <select> conservando su primera opción (la de «Seleccione…» o «Todos»). */
export function opciones(select, filas, texto = f => f.descripcion, valor = f => f.id) {
  select.length = 1;
  for (const fila of filas) select.add(new Option(texto(fila), valor(fila)));
}
