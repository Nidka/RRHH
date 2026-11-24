// Aviso flotante de la aplicación (región anunciada a lectores de pantalla).
// Los avisos de éxito e información se ocultan solos; los errores quedan hasta la siguiente acción.

const zona = () => document.getElementById('mensaje');
const DURACION_MS = 5000;
let temporizador;

/** Muestra un mensaje. tipo: 'info' | 'exito' | 'error'. Sin texto, limpia el aviso. */
export function mostrar(texto, tipo = 'info') {
  const destino = zona();
  clearTimeout(temporizador);
  destino.textContent = texto || '';
  destino.dataset.tipo = texto ? tipo : '';
  if (texto && tipo !== 'error') temporizador = setTimeout(() => mostrar(''), DURACION_MS);
}

export const exito = texto => mostrar(texto, 'exito');
export const error = texto => mostrar(texto, 'error');
export const limpiar = () => mostrar('');
