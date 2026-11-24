// Cliente único de la API: token antifalsificación en escrituras y mensajes de error uniformes.

let alPerderSesion = () => {};

/** Registra qué hacer cuando el servidor indica que la sesión ya no es válida (401). */
export function alExpirarSesion(manejador) {
  alPerderSesion = manejador;
}

/**
 * Llama a /api/<ruta>. Sin datos hace GET; con datos hace POST JSON con el token antifalsificación.
 * Devuelve el JSON de la respuesta (o null en 204) y lanza Error con un mensaje para el usuario.
 */
export async function api(ruta, datos) {
  const opciones = { cache: 'no-store' };
  if (datos !== undefined) {
    const respuestaToken = await fetch('/api/token', { cache: 'no-store' });
    if (!respuestaToken.ok) throw new Error('No se pudo preparar la solicitud.');
    const { token } = await respuestaToken.json();
    Object.assign(opciones, {
      method: 'POST',
      headers: { 'Content-Type': 'application/json', 'X-RRHH-CSRF': token },
      body: JSON.stringify(datos)
    });
  }
  const respuesta = await fetch('/api/' + ruta, opciones);
  if (respuesta.status === 401) {
    if (ruta !== 'login') alPerderSesion();
    throw new Error(ruta === 'login' ? 'Credenciales o rol no habilitado.' : 'Tu sesión terminó. Vuelve a iniciar sesión.');
  }
  if (respuesta.status === 403) throw new Error('Tu rol no está habilitado para esta consulta.');
  if (!respuesta.ok) {
    const error = await respuesta.json().catch(() => ({}));
    throw new Error(error.error || (respuesta.status === 429
      ? 'Demasiados intentos. Espera un minuto.' : 'No se pudo completar la operación.'));
  }
  return respuesta.status === 204 ? null : respuesta.json();
}

/** Arma la cadena de consulta omitiendo los campos vacíos. */
export function consulta(datos) {
  const parametros = new URLSearchParams();
  for (const [clave, valor] of (datos instanceof FormData ? datos.entries() : Object.entries(datos))) {
    if (valor !== '' && valor !== null && valor !== undefined) parametros.append(clave, valor);
  }
  return parametros.toString();
}
