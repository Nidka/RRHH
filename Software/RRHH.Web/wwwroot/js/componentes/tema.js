// Modo claro u oscuro: respeta la preferencia del sistema hasta que el usuario elige uno.

const CLAVE = 'rrhh-tema';

function guardado() {
  try { return localStorage.getItem(CLAVE); } catch { return null; }
}

/** Aplica el tema guardado o el del sistema operativo. */
export function aplicarTema() {
  const tema = guardado() || (matchMedia('(prefers-color-scheme: dark)').matches ? 'oscuro' : 'claro');
  fijar(tema);
}

function fijar(tema) {
  document.documentElement.dataset.tema = tema === 'oscuro' ? 'oscuro' : '';
  const boton = document.getElementById('tema');
  if (!boton) return;
  boton.querySelector('use').setAttribute('href', tema === 'oscuro' ? '#i-sol' : '#i-luna');
  boton.setAttribute('aria-pressed', String(tema === 'oscuro'));
}

/** Alterna el tema y recuerda la elección en este navegador. */
export function alternarTema() {
  const nuevo = document.documentElement.dataset.tema === 'oscuro' ? 'claro' : 'oscuro';
  try { localStorage.setItem(CLAVE, nuevo); } catch { /* sin almacenamiento: el cambio dura hasta recargar */ }
  fijar(nuevo);
}
