const byId = id => document.getElementById(id);
const mostrar = mensaje => { byId('mensaje').textContent = mensaje; };
const alta = byId('alta');
const turno = byId('guardar-turno');

function sesion(activa, permisos = {}) {
  byId('acceso').hidden = activa;
  byId('panel').hidden = !activa;
  byId('salir').hidden = !activa;
  byId('seccion-ausencias').hidden = !activa || !permisos.ausencias;
  byId('seccion-horarios').hidden = !activa || !permisos.horarios;
  byId('seccion-historico').hidden = !activa || !permisos.horarios;
  if (!activa) {
    byId('periodos').replaceChildren();
    byId('dias').replaceChildren();
    byId('personal-remoto').replaceChildren();
    byId('resumen-clasificacion').textContent = '';
    byId('resultado-ausencias').replaceChildren();
    byId('resultado-historico').replaceChildren();
    byId('ausencias').elements.motivo.length = 1;
    turno.elements.horario.length = 1;
    nuevoTurno();
    for (const formulario of ['alta', 'listado', 'reporte', 'clasificacion', 'ausencias', 'cargar-turno', 'historico-turnos']) byId(formulario).reset();
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
  if (respuesta.status === 401) {
    sesion(false);
    throw new Error(ruta === 'login' ? 'Credenciales o rol no habilitado.' : 'Vuelve a iniciar sesión.');
  }
  if (respuesta.status === 403) throw new Error('Tu rol no está habilitado para esta consulta.');
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
  await cargarSesion();
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

accion('clasificacion', async datos => {
  const resumen = byId('resumen-clasificacion');
  resumen.textContent = '';
  byId('personal-remoto').replaceChildren();
  const filas = await api('clasificacion-teletrabajo?' + new URLSearchParams(datos));
  if (byId('panel').hidden) return;
  const totales = filas.filter(fila => fila.clasificacion === 0).length;
  resumen.textContent = `${filas.length} personas encontradas: ${totales} total y ${filas.length - totales} parcial.`;
  resultados('personal-remoto', ['Empleado', 'Clasificación', 'Días remotos', 'Días laborables'], filas.map(fila => [
    fila.idEmpleado, fila.clasificacion === 0 ? 'Total' : 'Parcial', fila.diasRemotos, fila.diasLaborables
  ]));
});

accion('ausencias', async datos => {
  const destino = byId('resultado-ausencias');
  destino.replaceChildren();
  const parametros = new URLSearchParams(datos);
  if (!parametros.get('motivo')) parametros.delete('motivo');
  const filas = await api('ausencias?' + parametros);
  if (byId('seccion-ausencias').hidden) return;
  if (!filas.length) {
    destino.textContent = 'Nadie se ausenta en el periodo consultado.';
    return;
  }
  resultados('resultado-ausencias', ['Código', 'Persona', 'Motivo', 'Inicio', 'Fin', 'Días en el periodo'],
    filas.map(fila => [
      fila.idEmpleado, fila.empleado, fila.motivo, fila.inicio.slice(0, 10), fila.fin.slice(0, 10), fila.diasEnPeriodo
    ]));
});

function nuevoTurno() {
  turno.reset();
  turno.elements.numero.value = '0';
  turno.elements.empleado.readOnly = false;
  turno.querySelector('button').textContent = 'Registrar turno';
  byId('nuevo-turno').hidden = true;
  byId('estado-turno').textContent = '';
}

byId('nuevo-turno').addEventListener('click', nuevoTurno);
accion('cargar-turno', async datos => {
  const asignacion = await api(`horarios/asignaciones/${datos.get('empleado')}/${datos.get('numero')}`);
  if (byId('seccion-horarios').hidden) return;
  turno.elements.numero.value = asignacion.numero;
  turno.elements.empleado.value = asignacion.idEmpleado;
  turno.elements.empleado.readOnly = true;
  turno.elements.horario.value = asignacion.idHorario;
  turno.elements.desde.value = asignacion.desde.slice(0, 10);
  turno.elements.hasta.value = asignacion.hasta.slice(0, 10);
  turno.elements.documento.value = asignacion.documento ?? '';
  turno.elements.sisgedo.value = asignacion.sisgedo ?? '';
  turno.querySelector('button').textContent = 'Guardar cambios';
  byId('nuevo-turno').hidden = false;
  byId('estado-turno').textContent = 'Editando asignación ' + asignacion.numero + '.';
});
accion('guardar-turno', async datos => {
  const entrada = Object.fromEntries(datos);
  for (const campo of ['empleado', 'numero', 'horario']) entrada[campo] = Number(entrada[campo]);
  const guardado = await api('horarios/asignaciones', entrada);
  if (byId('seccion-horarios').hidden) return;
  byId('cargar-turno').elements.empleado.value = entrada.empleado;
  byId('cargar-turno').elements.numero.value = guardado.numero;
  nuevoTurno();
  byId('estado-turno').textContent = 'Asignación ' + guardado.numero + ' guardada.';
});

accion('historico-turnos', async datos => {
  byId('resultado-historico').replaceChildren();
  const filas = await api('horarios/historico?' + new URLSearchParams(datos));
  if (byId('seccion-historico').hidden) return;
  resultados('resultado-historico', ['Asignación', 'Desde', 'Hasta', 'Horario', 'Documento', 'Sisgedo'],
    filas.map(fila => [fila.n, fila.fechaInicio?.slice(0, 10) ?? '—', fila.fechaFin?.slice(0, 10) ?? '—',
      fila.descrip_Horario, fila.nroDocumento ?? '', fila.sisgedo ?? '']));
});

async function cargarOpciones(ruta, seccion, control) {
  try {
    const filas = await api(ruta);
    if (byId(seccion).hidden) return;
    control.length = 1;
    for (const fila of filas) control.add(new Option(fila.descripcion, fila.id));
  } catch (error) {
    mostrar(error.message);
  }
}

async function cargarSesion() {
  const usuario = await api('sesion');
  sesion(true, usuario);
  await Promise.all([
    usuario.ausencias && cargarOpciones('ausencias/motivos', 'seccion-ausencias', byId('ausencias').elements.motivo),
    usuario.horarios && cargarOpciones('horarios/catalogo', 'seccion-horarios', turno.elements.horario)
  ]);
}

cargarSesion().catch(() => sesion(false));
