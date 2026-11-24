// Recorrido de la interfaz web con Chrome (datos ficticios de la base de demostración).
// Requisitos: Google Chrome y `npm i playwright-core` en una carpeta de trabajo (no en el repositorio).
// Uso: node recorrido-web.mjs <url-base> <clave-demo>. Recrear la base y arrancar el servidor desde cero antes.
// Nunca usar contra la base compartida ni contra producción: registra turnos, periodos, permisos y motivos.
import { chromium } from 'playwright-core';
import { mkdirSync } from 'node:fs';

const [, , URL_BASE, CLAVE] = process.argv;
const CAPTURAS = new URL('./capturas/', import.meta.url).pathname;
mkdirSync(CAPTURAS, { recursive: true });
const errores = [];
const resultados = [];
const ok = texto => resultados.push('ok   ' + texto);
const falla = texto => resultados.push('FALLA ' + texto);
async function verificar(texto, condicion) { (await condicion) ? ok(texto) : falla(texto); }

const navegador = await chromium.launch({ channel: 'chrome', headless: true });
let pagina;
let pendientes = 0;

async function nuevaPagina(ancho = 1440, alto = 900) {
  const contexto = await navegador.newContext({ viewport: { width: ancho, height: alto }, locale: 'es-PE', colorScheme: 'light' });
  const p = await contexto.newPage();
  p.on('pageerror', e => errores.push('pageerror: ' + e.message));
  // Las respuestas 4xx esperadas (sesión inicial, rechazos de negocio) no son errores de JavaScript.
  p.on('console', m => { if (m.type() === 'error' && !m.text().startsWith('Failed to load resource')) errores.push('console: ' + m.text()); });
  p.on('request', r => { if (r.url().includes('/api/')) pendientes++; });
  for (const evento of ['requestfinished', 'requestfailed']) p.on(evento, r => { if (r.url().includes('/api/')) pendientes--; });
  return p;
}
async function quieto() {
  await pagina.waitForTimeout(80);
  for (let i = 0; i < 100 && pendientes > 0; i++) await pagina.waitForTimeout(50);
  await pagina.waitForTimeout(120);
}
const mensaje = () => pagina.locator('#mensaje').innerText();
const tipoMensaje = () => pagina.locator('#mensaje').getAttribute('data-tipo');
async function entrar(usuario) {
  await pagina.goto(URL_BASE);
  await pagina.waitForSelector('#acceso:not([hidden])');
  await pagina.fill('#login [name=login]', usuario);
  await pagina.fill('#login [name=password]', CLAVE);
  await pagina.click('#login button');
  await pagina.waitForSelector('#aplicacion:not([hidden])');
  await quieto();
}
async function abrir(clave, titulo) {
  await pagina.click(`#menu a[data-pantalla="${clave}"]`);
  await pagina.waitForFunction(t => document.querySelector('#vista h1')?.firstChild?.textContent === t, titulo);
  await quieto();
}
async function elegirEmpleado(formulario, texto) {
  const buscador = formulario.locator('.selector-empleado input[type=search]').first();
  await buscador.fill(texto);
  await formulario.locator('.selector-empleado li[role=option]').first().waitFor();
  await buscador.press('Enter');
  await quieto();
}
async function enviar(formulario) {
  await formulario.locator('button:not([type=button])').first().click();
  await quieto();
}

try {
  pagina = await nuevaPagina();
  await pagina.goto(URL_BASE);
  await pagina.waitForSelector('#acceso:not([hidden])');
  ok('sin sesión se muestra el acceso');
  await pagina.fill('#login [name=login]', 'operador');
  await pagina.fill('#login [name=password]', 'incorrecta');
  await pagina.click('#login button');
  await pagina.waitForFunction(() => document.querySelector('#mensaje').textContent.length > 0);
  await verificar('credenciales erróneas muestran error', (await tipoMensaje()) === 'error');

  // ---------- Operador con todos los permisos ----------
  await entrar('operador');
  const modulos = await pagina.locator('#menu .menu-modulo h2').allTextContents();
  await verificar('operador ve 5 módulos en orden: ' + modulos.join(' | '),
    modulos.join('|') === 'Gestión de turnos|Permisos y licencias|Vacaciones|Teletrabajo y presencialidad|Reportes generales');
  await verificar('ningún texto dice «piloto»', !(await pagina.locator('body').innerText()).toLowerCase().includes('piloto'));
  await verificar('el inicio muestra indicadores de ausencias, teletrabajo y vacaciones', (await pagina.locator('.indicador').count()) === 3);
  await verificar('el inicio muestra los gráficos de teletrabajo y ausencias', (await pagina.locator('.portada ~ .rejilla.columnas-2 > .tarjeta').count()) === 2);
  await verificar('el perfil muestra el rol Operador RRHH', (await pagina.locator('#rol').innerText()) === 'Operador RRHH');
  await pagina.screenshot({ path: CAPTURAS + '01-inicio.png' });

  const pantallas = await pagina.locator('#menu a[data-pantalla]').evaluateAll(as => as.map(a => [a.dataset.pantalla, a.textContent]));
  await verificar('operador tiene sus 14 pantallas en el menú (la 15.ª, Mis vacaciones, es del empleado)', pantallas.length === 14);
  for (const [clave, titulo] of pantallas) {
    await abrir(clave, titulo);
    await verificar(`abre «${titulo}» sin error`, (await tipoMensaje()) !== 'error');
  }

  // RF-01: asignar turno con el buscador, ver la línea de tiempo, editar y rechazar solapamiento
  await abrir('asignar-turno', 'Asignar turno por periodo');
  let form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'fic');
  await verificar('el buscador muestra código y documento', (await form.locator('.ayuda').innerText()).includes('Código 101'));
  await form.locator('input[name=horario]').first().check();
  await form.locator('[name=desde]').fill('2026-12-01');
  await form.locator('[name=hasta]').fill('2026-12-15');
  await enviar(form);
  await verificar('RF-01 guarda la asignación: ' + await mensaje(), (await tipoMensaje()) === 'exito');
  await verificar('RF-01 lista la asignación del empleado', (await pagina.locator('#vista table tbody tr').count()) === 1);
  await verificar('RF-01 dibuja la línea de tiempo', (await pagina.locator('#vista .tramo').count()) === 1);
  await pagina.locator('#vista table button', { hasText: 'Editar' }).click();
  await quieto();
  await verificar('RF-01 «Editar» carga el periodo', (await form.locator('[name=desde]').inputValue()) === '2026-12-01');
  await pagina.screenshot({ path: CAPTURAS + '02-rf01-editando.png' });
  await form.locator('[data-nuevo]').click();
  await form.locator('input[name=horario]').first().check();
  await form.locator('[name=desde]').fill('2026-12-10');
  await form.locator('[name=hasta]').fill('2026-12-20');
  await enviar(form);
  await verificar('RF-01 rechaza un periodo solapado: ' + await mensaje(), (await tipoMensaje()) === 'error');

  // RF-02 y validación del selector
  await abrir('historico-turnos', 'Histórico de turnos');
  form = pagina.locator('#vista form').first();
  await form.locator('input[type=search]').fill('zzz');
  await enviar(form);
  await verificar('el selector exige elegir un empleado de la lista', await form.locator('input[type=search]').evaluate(e => !e.checkValidity()));
  await elegirEmpleado(form, 'fic');
  await enviar(form);
  await verificar('RF-02 muestra el histórico', (await pagina.locator('#vista table tbody tr').count()) === 1);

  // RF-13: periodo parcial con patrón y rechazo por solapamiento
  await abrir('periodos-teletrabajo', 'Periodos de teletrabajo');
  form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'operador');
  await form.locator('input[name=modalidad][value=P]').check();
  await form.locator('input[name=dia][value="1"]').check();
  await form.locator('input[name=dia][value="4"]').check();
  await form.locator('[name=desde]').fill('2026-11-09');
  await form.locator('[name=hasta]').fill('2026-11-13');
  await enviar(form);
  await verificar('RF-13 registra el periodo: ' + await mensaje(), (await tipoMensaje()) === 'exito');
  await verificar('RF-13 lista el patrón Lun, Mié', (await pagina.locator('#vista table').innerText()).includes('Lun, Mié'));
  await enviar(form);
  await verificar('RF-13 rechaza el solapamiento: ' + await mensaje(), (await tipoMensaje()) === 'error');
  await pagina.screenshot({ path: CAPTURAS + '03-rf13-solapamiento.png' });

  // RF-14 y RF-16 con el periodo recién creado (lunes 9 cuenta; miércoles 11 es feriado ficticio)
  await abrir('dias-teletrabajo', 'Días de teletrabajo');
  form = pagina.locator('#vista form').first();
  await form.locator('[name=desde]').fill('2026-11-09');
  await form.locator('[name=hasta]').fill('2026-11-15');
  await enviar(form);
  const filaDias = await pagina.locator('#vista tbody tr').first().innerText();
  await verificar('RF-14 muestra el nombre y descuenta el feriado del 11/11 (1 día): ' + filaDias.replace(/\s+/g, ' '),
    filaDias.includes('Ficticio, Operador') && /\s1$/.test(filaDias.trim()));
  await abrir('teletrabajo-total-parcial', 'Teletrabajo total o parcial');
  form = pagina.locator('#vista form').first();
  await form.locator('[name=desde]').fill('2026-11-09');
  await form.locator('[name=hasta]').fill('2026-11-13');
  await enviar(form);
  const tablaTotal = await pagina.locator('#vista table').innerText();
  await verificar('RF-16 clasifica como Parcial con 1 de 4 días', tablaTotal.includes('Parcial') && tablaTotal.includes('1 / 4'));
  await pagina.screenshot({ path: CAPTURAS + '04-rf16.png' });

  // RF-03: permiso y rechazo del mismo día
  await abrir('registro-permisos', 'Registro de permisos y licencias');
  form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'fic');
  await form.locator('[name=idMotivo]').fill('20');
  await form.locator('[name=desde]').fill('2026-12-02');
  await form.locator('[name=hasta]').fill('2026-12-02');
  await enviar(form);
  await verificar('RF-03 guarda el permiso: ' + await mensaje(), (await tipoMensaje()) === 'exito');
  await form.locator('[data-nuevo]').click();
  await elegirEmpleado(form, 'fic');
  await form.locator('[name=idMotivo]').fill('20');
  await form.locator('[name=desde]').fill('2026-12-02');
  await form.locator('[name=hasta]').fill('2026-12-02');
  await enviar(form);
  await verificar('RF-03 rechaza dos permisos el mismo día: ' + await mensaje(), (await tipoMensaje()) === 'error');
  await pagina.screenshot({ path: CAPTURAS + '05-rf03-mismo-dia.png' });

  // RF-10: media jornada de vacaciones aprobada (motivo 10, marcado como vacaciones en la demo)
  await form.locator('[data-nuevo]').click();
  await elegirEmpleado(form, 'fic');
  await form.locator('[name=idMotivo]').fill('10');
  await form.locator('[name=estado]').selectOption('Aprobado');
  await form.locator('[name=desde]').fill('2026-12-03');
  await form.locator('[name=hasta]').fill('2026-12-03');
  await form.locator('input[name=mediaJornadaVacaciones]').check();
  await enviar(form);
  await verificar('RF-10 aprueba una media jornada de vacaciones: ' + await mensaje(), (await tipoMensaje()) === 'exito');

  // RF-04 y RF-05: alta y baja de motivo
  await abrir('motivos-permiso', 'Motivos de permiso');
  form = pagina.locator('#vista form').first();
  await form.locator('[name=tipo]').selectOption({ index: 1 });
  await quieto();
  await form.locator('[name=descripcion]').fill('Motivo QA ficticio');
  await form.locator('[name=abreviatura]').fill('MQA');
  await enviar(form);
  await verificar('RF-04 agrega el motivo: ' + await mensaje(), (await tipoMensaje()) === 'exito');
  const baja = pagina.locator('#vista form').nth(1);
  const opcion = await baja.locator('option', { hasText: 'Motivo QA ficticio' }).getAttribute('value');
  await baja.locator('[name=id]').selectOption(opcion);
  await baja.locator('[name=confirmar]').check();
  await enviar(baja);
  await verificar('RF-05 elimina el motivo: ' + await mensaje(), (await tipoMensaje()) === 'exito');

  // RF-07, RF-08 (con la media jornada) y RF-09
  await abrir('vacaciones-generadas', 'Vacaciones generadas');
  form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'fic');
  await form.locator('[name=corte]').fill('2026-11-20');
  await enviar(form);
  await verificar('RF-07 genera 60 días por dos aniversarios', (await pagina.locator('#vista .indicadores').innerText()).includes('60'));
  await abrir('saldo-vacaciones', 'Vacaciones pendientes de goce');
  form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'fic');
  await form.locator('[name=corte]').fill('2026-12-31');
  await enviar(form);
  const saldo = await pagina.locator('#vista .indicadores').innerText();
  await verificar('RF-08 descuenta la media jornada: ' + saldo.replace(/\s+/g, ' '), saldo.includes('0.5') && saldo.includes('59.5'));
  await verificar('RF-08 muestra la media jornada en el detalle', (await pagina.locator('#vista table').innerText()).includes('Media jornada'));
  await pagina.screenshot({ path: CAPTURAS + '06-rf08-saldo.png' });
  await abrir('vacaciones-truncas', 'Vacaciones truncas');
  form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'fic');
  await form.locator('[name=cese]').fill('2026-11-20');
  await enviar(form);
  await verificar('RF-09 calcula 21,67 días truncos', (await pagina.locator('#vista .indicadores').innerText()).includes('21.67'));

  // RF-11 con nombres y RF-15 con calendario
  await abrir('reporte-vacaciones', 'Reporte de vacaciones');
  form = pagina.locator('#vista form').first();
  await form.locator('[name=corte]').fill('2026-12-31');
  await enviar(form);
  await verificar('RF-11 lista personas con nombre', (await pagina.locator('#vista table').innerText()).includes('Ficticio, Operador'));
  await abrir('presencialidad', 'Presencialidad y teletrabajo por persona');
  form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'fic');
  await form.locator('[name=desde]').fill('2026-11-01');
  await form.locator('[name=hasta]').fill('2026-11-30');
  await enviar(form);
  await verificar('RF-15 dibuja un día por fecha en el calendario', (await pagina.locator('#vista .calendario .dia:not(.vacio-dia)').count()) === 30);

  // RF-17 y RF-18
  await abrir('asistencia-feriados', 'Asistencia con feriados');
  form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'fic');
  await form.locator('[name=desde]').fill('2026-11-01');
  await form.locator('[name=hasta]').fill('2026-11-30');
  await enviar(form);
  await verificar('RF-17 muestra el total de días computados', (await pagina.locator('#vista .indicadores').innerText()).includes('Días computados'));
  await abrir('ausencias-periodo', 'Ausencias por periodo');
  form = pagina.locator('#vista form').first();
  await form.locator('[name=desde]').fill('2026-11-01');
  await form.locator('[name=hasta]').fill('2026-11-30');
  await enviar(form);
  await verificar('RF-18 lista ausencias con nombre', (await pagina.locator('#vista table').innerText()).includes('Ficticio'));
  await pagina.screenshot({ path: CAPTURAS + '07-rf18.png' });

  // Búsqueda rápida, modo oscuro persistente y ruta inexistente
  await pagina.keyboard.press('Control+k');
  await pagina.waitForSelector('#paleta:not([hidden])');
  await pagina.keyboard.type('trunc');
  await pagina.keyboard.press('Enter');
  await pagina.waitForFunction(() => location.hash === '#/vacaciones-truncas');
  ok('Ctrl+K y «trunc» abre Vacaciones truncas');
  await pagina.click('#tema');
  await pagina.reload();
  await pagina.waitForSelector('#aplicacion:not([hidden])');
  await verificar('el modo oscuro se conserva al recargar', (await pagina.evaluate(() => document.documentElement.dataset.tema)) === 'oscuro');
  await pagina.screenshot({ path: CAPTURAS + '08-oscuro.png' });
  await pagina.click('#tema');
  await pagina.goto(URL_BASE + '/#/no-existe');
  await pagina.waitForFunction(() => document.querySelector('#vista .portada'));
  await verificar('una ruta inexistente vuelve al inicio con aviso', (await tipoMensaje()) === 'error');
  await pagina.click('#salir');
  await pagina.waitForSelector('#acceso:not([hidden])');
  ok('cerrar sesión vuelve al acceso');

  // ---------- Rol solo teletrabajo ----------
  await entrar('solo_teletrabajo');
  const soloPantallas = await pagina.locator('#menu a[data-pantalla]').allTextContents();
  await verificar('solo_teletrabajo ve solo sus 3 pantallas: ' + soloPantallas.join(', '), soloPantallas.length === 3
    && (await pagina.locator('#menu .menu-modulo h2').allTextContents()).join('|') === 'Teletrabajo y presencialidad');
  await verificar('su inicio muestra solo el indicador de teletrabajo', (await pagina.locator('.indicador').count()) === 1);
  await pagina.goto(URL_BASE + '/#/saldo-vacaciones');
  await pagina.waitForFunction(() => document.querySelector('#vista .portada'));
  await verificar('no abre vacaciones por enlace directo', (await tipoMensaje()) === 'error');
  await pagina.click('#salir');
  await pagina.waitForSelector('#acceso:not([hidden])');

  // ---------- Rol empleado (autoconsulta, RF-12) ----------
  await entrar('empleado');
  await pagina.waitForFunction(() => location.hash === '#/mis-vacaciones');
  await quieto();
  await verificar('el empleado entra directo a Mis vacaciones y ve solo Mi cuenta',
    (await pagina.locator('#menu .menu-modulo h2').allTextContents()).join('|') === 'Mi cuenta' && (await pagina.locator('#rol').innerText()) === 'Empleado');
  form = pagina.locator('#vista form').first();
  await form.locator('[name=corte]').fill('2026-12-31');
  await enviar(form);
  await verificar('RF-12 el empleado ve su media jornada usada', (await pagina.locator('#vista .indicadores').innerText()).includes('0.5'));
  await pagina.screenshot({ path: CAPTURAS + '09-rf12-empleado.png' });
  await pagina.goto(URL_BASE + '/#/asignar-turno');
  await pagina.waitForFunction(() => document.querySelector('#vista .portada'));
  await verificar('el empleado no abre pantallas de operador', (await tipoMensaje()) === 'error');

  // ---------- Celular ----------
  pagina = await nuevaPagina(390, 844);
  await entrar('operador');
  const lateral = async () => (await pagina.locator('#lateral').boundingBox()).x;
  await verificar('en celular el menú empieza oculto', (await lateral()) < 0);
  await pagina.screenshot({ path: CAPTURAS + '10-celular.png' });
  await pagina.click('#abrir-menu');
  await pagina.waitForTimeout(400);
  await verificar('el botón Menú lo abre', (await lateral()) >= 0);
  await pagina.screenshot({ path: CAPTURAS + '11-celular-menu.png' });
  await pagina.click('#menu a[data-pantalla="asignar-turno"]');
  await pagina.waitForTimeout(500);
  await verificar('elegir una pantalla cierra el menú', (await lateral()) < 0);
} catch (e) {
  falla('excepción: ' + e.message.split('\n')[0]);
  await pagina.screenshot({ path: CAPTURAS + '99-falla.png', fullPage: true }).catch(() => {});
} finally {
  await navegador.close();
}
for (const linea of resultados) console.log(linea);
for (const e of errores) console.log('ERROR JS ' + e);
const fallas = resultados.filter(r => r.startsWith('FALLA')).length + errores.length;
console.log(fallas ? `\n${fallas} FALLA(S)` : `\nRECORRIDO CORRECTO: ${resultados.length} verificaciones`);
process.exit(fallas ? 1 : 0);
