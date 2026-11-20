const byId = id => document.getElementById(id);
const mostrar = mensaje => { byId('mensaje').textContent = mensaje; };
const alta = byId('alta');
const turno = byId('guardar-turno');
const altaMotivo = byId('alta-motivo');
const bajaMotivo = byId('baja-motivo');

function sesion(activa, permisos = {}) {
  byId('acceso').hidden = activa;
  byId('panel').hidden = !activa;
  byId('salir').hidden = !activa;
  byId('seccion-ausencias').hidden = !activa || !permisos.ausencias;
  byId('seccion-horarios').hidden = !activa || !permisos.horarios;
  byId('seccion-historico').hidden = !activa || !permisos.horarios;
  byId('seccion-motivos').hidden = !activa || !permisos.motivos;
  byId('seccion-asistencia').hidden = !activa || !permisos.asistencia;
  byId('seccion-vacaciones').hidden = !activa || !permisos.vacaciones;
  byId('seccion-permisos').hidden = !activa || !permisos.permisos;
  if (!activa) {
    byId('periodos').replaceChildren();
    byId('dias').replaceChildren();
    byId('personal-remoto').replaceChildren();
    byId('resumen-clasificacion').textContent = '';
    byId('resultado-ausencias').replaceChildren();
    byId('resultado-historico').replaceChildren();
    byId('detalle-asistencia').replaceChildren();
    byId('total-asistencia').textContent = '';
    byId('reporte-asistencia').reset();
    byId('vacaciones-generadas').reset();
    byId('resultado-vacaciones').replaceChildren();
    byId('saldo-vacaciones').reset();
    byId('resumen-saldo').textContent='';
    byId('consumos-vacaciones').replaceChildren();
    byId('cargar-permiso').reset();
    nuevoPermiso();
    limpiarMotivos();
    byId('estado-motivo').textContent = '';
    altaMotivo.elements.tipo.length = 1;
    altaMotivo.reset();
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

function nuevoPermiso() {
  const form = byId('guardar-permiso');
  form.reset();
  form.elements.numero.value = '0';
  form.elements.idEmpleado.readOnly = false;
  byId('estado-permiso').textContent = 'Nuevo permiso';
}
accion('saldo-vacaciones',async datos => {
  byId('resumen-saldo').textContent='';
  byId('consumos-vacaciones').replaceChildren();
  const saldo=await api('vacaciones/saldo?'+new URLSearchParams(datos));
  byId('resumen-saldo').textContent=`Generadas: ${saldo.generadas} · usadas: ${saldo.usadas} · pendientes: ${saldo.pendientes} días`;
  resultados('consumos-vacaciones',['Permiso','Desde','Hasta','Días'],saldo.consumos.map(c => [c.numero,c.desde.slice(0,10),c.hasta.slice(0,10),c.dias]));
});
byId('nuevo-permiso').addEventListener('click', nuevoPermiso);
accion('cargar-permiso', async datos => {
  nuevoPermiso();
  const permiso = await api('permisos?' + new URLSearchParams(datos));
  const form = byId('guardar-permiso');
  for (const campo of ['numero', 'idEmpleado', 'idMotivo', 'estado', 'lugar', 'referencia', 'autorizacion', 'observacion']) {
    form.elements[campo].value = permiso[campo] ?? '';
  }
  for (const campo of ['desde', 'hasta']) form.elements[campo].value = permiso[campo].slice(0, 10);
  for (const campo of ['dia', 'retorno','mediaJornadaVacaciones']) form.elements[campo].checked = permiso[campo] === true;
  form.elements.idEmpleado.readOnly = true;
  byId('estado-permiso').textContent = 'Editando permiso ' + permiso.numero + ' del empleado ' + permiso.idEmpleado;
});
accion('guardar-permiso', async datos => {
  const entrada = Object.fromEntries(datos);
  for (const campo of ['numero', 'idEmpleado', 'idMotivo']) entrada[campo] = Number(entrada[campo]);
  for (const campo of ['dia', 'retorno','mediaJornadaVacaciones']) entrada[campo] = datos.has(campo);
  const resultado = await api('permisos', entrada);
  const form = byId('guardar-permiso');
  form.elements.numero.value = resultado.numero;
  form.elements.idEmpleado.readOnly = true;
  byId('cargar-permiso').elements.empleado.value = entrada.idEmpleado;
  byId('cargar-permiso').elements.numero.value = resultado.numero;
  byId('estado-permiso').textContent = 'Permiso ' + resultado.numero + ' guardado: ' + entrada.estado;
  mostrar('Permiso guardado correctamente.');
});

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

function limpiarMotivos() {
  byId('resultado-motivos').replaceChildren();
  bajaMotivo.elements.id.length = 1;
  bajaMotivo.reset();
  bajaMotivo.hidden = true;
}

altaMotivo.elements.tipo.addEventListener('change', () => {
  limpiarMotivos();
  byId('estado-motivo').textContent = '';
});

byId('consultar-motivos').addEventListener('click', async evento => {
  const tipo = altaMotivo.elements.tipo.value;
  if (!tipo) { altaMotivo.elements.tipo.reportValidity(); return; }
  const boton = evento.currentTarget;
  boton.disabled = true;
  limpiarMotivos();
  try {
    const filas = await api('motivos-permiso?tipo=' + encodeURIComponent(tipo));
    if (byId('seccion-motivos').hidden || tipo !== altaMotivo.elements.tipo.value) return;
    resultados('resultado-motivos', ['Código', 'Descripción', 'Abreviatura', 'Modalidad'],
      filas.map(fila => [fila.id, fila.descripcion, fila.abreviatura ?? '', fila.modalidad ?? '']));
    for (const fila of filas) bajaMotivo.elements.id.add(new Option(fila.id + ' · ' + fila.descripcion, fila.id));
    bajaMotivo.hidden = filas.length === 0;
  } catch (error) {
    mostrar(error.message);
  } finally {
    boton.disabled = false;
  }
});

accion('alta-motivo', async datos => {
  byId('estado-motivo').textContent = '';
  const entrada = Object.fromEntries(datos);
  entrada.tipo = Number(entrada.tipo);
  entrada.salario = entrada.salario === '' ? null : entrada.salario === 'true';
  const creado = await api('motivos-permiso', entrada);
  if (byId('seccion-motivos').hidden) return;
  altaMotivo.elements.descripcion.value = '';
  altaMotivo.elements.abreviatura.value = '';
  limpiarMotivos();
  byId('estado-motivo').textContent = 'Motivo ' + creado.id + ' registrado.';
});

bajaMotivo.elements.id.addEventListener('change', () => { bajaMotivo.elements.confirmar.checked = false; });
accion('baja-motivo', async datos => {
  byId('estado-motivo').textContent = '';
  bajaMotivo.elements.confirmar.checked = false;
  const id = datos.get('id');
  await api('motivos-permiso/' + encodeURIComponent(id) + '/eliminar', {});
  if (byId('seccion-motivos').hidden) return;
  limpiarMotivos();
  byId('estado-motivo').textContent = 'Motivo ' + id + ' eliminado. Consulta el tipo para actualizar el listado.';
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
    usuario.horarios && cargarOpciones('horarios/catalogo', 'seccion-horarios', turno.elements.horario),
    usuario.motivos && cargarOpciones('motivos-permiso/tipos', 'seccion-motivos', altaMotivo.elements.tipo)
  ]);
}

accion('reporte-asistencia', async datos => {
  byId('detalle-asistencia').replaceChildren();
  byId('total-asistencia').textContent = '';
  const resumen = await api('asistencia?' + new URLSearchParams(datos));
  if (byId('seccion-asistencia').hidden) return;
  byId('total-asistencia').textContent = 'Total de días computados: ' + resumen.total;
  resultados('detalle-asistencia', ['Fecha', 'Asistencia registrada', 'No laborable', 'Cuenta en total'],
    resumen.dias.map(dia => [dia.fecha.slice(0, 10), dia.asistio ? 'Sí' : 'No',
      dia.noLaborable ? 'Sí' : 'No', dia.cuentaEnTotal ? 'Sí' : 'No']));
});

accion('vacaciones-generadas', async datos => {
  byId('resultado-vacaciones').replaceChildren();
  const fila = await api('vacaciones/generadas?' + new URLSearchParams(datos));
  if (byId('seccion-vacaciones').hidden) return;
  resultados('resultado-vacaciones', ['Empleado', 'Ingreso', 'Corte', 'Años cumplidos', 'Días por año', 'Días generados'],
    [[fila.empleado, fila.ingreso.slice(0, 10), fila.corte.slice(0, 10),
      fila.aniosCumplidos, fila.diasAnuales, fila.generadas]]);
});

cargarSesion().catch(() => sesion(false));
