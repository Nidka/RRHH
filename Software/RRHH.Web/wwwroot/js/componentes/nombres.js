// Nombres de empleados para los reportes que la API devuelve solo con códigos (CR-019).

import { api } from './api.js';

/** Devuelve un Map código → { nombreCompleto, documento, activo } para los códigos dados. */
export async function nombresDe(codigos) {
  const unicos = [...new Set(codigos.filter(c => Number(c) > 0))];
  if (!unicos.length) return new Map();
  const filas = await api('empleados/nombres?codigos=' + encodeURIComponent(unicos.join(',')));
  return new Map(filas.map(f => [f.idEmpleado, f]));
}
