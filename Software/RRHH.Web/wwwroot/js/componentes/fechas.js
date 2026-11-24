// Fechas: la API usa yyyy-MM-dd; la pantalla muestra dd/mm/aaaa.

const dosDigitos = n => String(n).padStart(2, '0');
const iso = fecha => `${fecha.getFullYear()}-${dosDigitos(fecha.getMonth() + 1)}-${dosDigitos(fecha.getDate())}`;

/** Fecha de hoy en formato de la API. */
export const hoy = () => iso(new Date());

/** Primer día del mes actual en formato de la API. */
export const inicioDeMes = () => { const d = new Date(); return iso(new Date(d.getFullYear(), d.getMonth(), 1)); };

/** Convierte '2026-11-09' o '2026-11-09T00:00:00' a '09/11/2026'. Vacío si no hay fecha. */
export function mostrarFecha(valor) {
  if (!valor) return '';
  const [anio, mes, dia] = valor.slice(0, 10).split('-');
  return `${dia}/${mes}/${anio}`;
}

/** Recorta un valor de fecha de la API al formato de un <input type="date">. */
export const paraCampo = valor => (valor ? valor.slice(0, 10) : '');
