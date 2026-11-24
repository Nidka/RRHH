// Mensaje general de la aplicación (región anunciada a lectores de pantalla).

const zona = () => document.getElementById('mensaje');

/** Muestra un mensaje. tipo: 'info' | 'exito' | 'error'. Sin texto, limpia la zona. */
export function mostrar(texto, tipo = 'info') {
  const destino = zona();
  destino.textContent = texto || '';
  destino.dataset.tipo = texto ? tipo : '';
}

export const exito = texto => mostrar(texto, 'exito');
export const error = texto => mostrar(texto, 'error');
export const limpiar = () => mostrar('');
