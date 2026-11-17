const byId = id => document.getElementById(id);
const mostrar = mensaje => { byId('mensaje').textContent = mensaje; };
const alta = byId('alta');

function sesion(activa) {
  byId('acceso').hidden = activa;
  byId('panel').hidden = !activa;
  byId('salir').hidden = !activa;
  if (!activa) {
    byId('periodos').replaceChildren();
    byId('dias').replaceChildren();
    for (const formulario of ['alta', 'listado', 'reporte']) byId(formulario).reset();
    byId('patron').hidden = true;
  }
}

async function api(ruta, datos) {
  const opciones = { cache: 'no-store' };
  if (datos !== undefined) {
    const respuestaToken = await fetch('/api/token', { cache: 'no-store' });
    if (!respuestaToken.ok) throw new Error('No se pudo preparar la solicitud.');
    const { token } = await respuestaToken.json();
    Object.assign(opciones, {
      method: 'POST', headers: { 'Content-Type': 'application/json', 'X-RRHH-CSRF': token },
      body: JSON.stringify(datos)
    });
  }
  const respuesta = await fetch('/api/' + ruta, opciones);
  if (respuesta.status === 401 || respuesta.status === 403) {
    sesion(false);
    throw new Error(ruta === 'login' ? 'Credenciales o rol no habilitado.' : 'Vuelve a iniciar sesión.');
  }
  if (!respuesta.ok) {
    const error = await respuesta.json().catch(() => ({}));
    throw new Error(error.error || (respuesta.status === 429
      ? 'Demasiados intentos. Espera un minuto.' : 'No se pudo completar la operación.'));
  }
  return respuesta.status === 204 ? null : respuesta.json();
}

function resultados(id, columnas, filas) {
  const destino = byId(id);
  destino.replaceChildren();
  if (!filas.length) { destino.textContent = 'No se encontraron resultados.'; return; }
  const tabla = document.createElement('table');
  const encabezado = tabla.createTHead().insertRow();
  for (const columna of columnas) {
    const th = document.createElement('th');
    th.scope = 'col';
    th.textContent = columna;
    encabezado.append(th);
  }
  const cuerpo = tabla.createTBody();
  for (const fila of filas) {
    const tr = cuerpo.insertRow();
    for (const dato of fila) tr.insertCell().textContent = dato;
  }
  destino.append(tabla);
}

function accion(id, ejecutar) {
  const form = byId(id);
  form.addEventListener('submit', async evento => {
    evento.preventDefault();
    const boton = form.querySelector('button');
    boton.disabled = true;
    mostrar('');
    try { await ejecutar(new FormData(form)); }
    catch (error) { mostrar(error.message); }
    finally { boton.disabled = false; }
  });
}

accion('login', async datos => {
  try { await api('login', Object.fromEntries(datos)); }
  finally { byId('login').reset(); }
  sesion(true);
});
byId('salir').addEventListener('click', async () => {
  try { await api('salir', {}); sesion(false); mostrar('Sesión cerrada.'); }
  catch (error) { mostrar(error.message); }
});
alta.elements.modalidad.addEventListener('change', () => {
  byId('patron').hidden = alta.elements.modalidad.value !== 'P';
});
accion('alta', async datos => {
  const entrada = Object.fromEntries(datos);
  delete entrada.dia;
  entrada.empleado = Number(entrada.empleado);
  entrada.diasRemotos = entrada.modalidad === 'T' ? 31 : datos.getAll('dia').reduce((suma, dia) => suma | Number(dia), 0);
  const registro = await api('periodos', entrada);
  byId('listado').elements.empleado.value = entrada.empleado;
  mostrar('Periodo registrado con código ' + registro.id + '. Puedes consultarlo en Periodos vigentes.');
});
accion('listado', async datos => {
  byId('periodos').replaceChildren();
  const filas = await api('periodos?' + new URLSearchParams(datos));
  const abreviaturas = ['Lun', 'Mar', 'Mié', 'Jue', 'Vie'];
  resultados('periodos', ['Código', 'Desde', 'Hasta', 'Modalidad', 'Patrón remoto'], filas.map(fila => [
    fila.id, fila.desde.slice(0, 10), fila.hasta.slice(0, 10), fila.modalidad === 0 ? 'Total' : 'Parcial',
    abreviaturas.filter((_, i) => fila.diasRemotos & (1 << i)).join(', ')
  ]));
});
accion('reporte', async datos => {
  byId('dias').replaceChildren();
  const parametros = new URLSearchParams(datos);
  if (!parametros.get('empleado')) parametros.delete('empleado');
  const filas = await api('reporte?' + parametros);
  resultados('dias', ['Empleado', 'Días remotos'], filas.map(fila => [fila.idEmpleado, fila.dias]));
});

api('sesion').then(() => sesion(true)).catch(() => sesion(false));
