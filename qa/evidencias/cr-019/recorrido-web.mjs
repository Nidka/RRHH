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
const ok = (texto) => { resultados.push('ok   ' + texto); };
const falla = (texto) => { resultados.push('FALLA ' + texto); };
async function verificar(texto, condicion) { (await condicion) ? ok(texto) : falla(texto); }

const navegador = await chromium.launch({ channel: 'chrome', headless: true });
const contexto = await navegador.newContext({ viewport: { width: 1366, height: 860 }, locale: 'es-PE' });
const pagina = await contexto.newPage();
pagina.on('pageerror', e => errores.push('pageerror: ' + e.message));
// Las respuestas 4xx esperadas (sesión inicial, rechazos de negocio) se registran aparte: no son errores de JavaScript.
pagina.on('console', m => { if (m.type() === 'error' && !m.text().startsWith('Failed to load resource')) errores.push('console: ' + m.text()); });
let pendientes = 0;
pagina.on('request', r => { if (r.url().includes('/api/')) pendientes++; });
for (const evento of ['requestfinished', 'requestfailed']) pagina.on(evento, r => { if (r.url().includes('/api/')) pendientes--; });
async function quieto() {
  await pagina.waitForTimeout(80);
  for (let i = 0; i < 100 && pendientes > 0; i++) await pagina.waitForTimeout(50);
  await pagina.waitForTimeout(80);
}

const mensaje = () => pagina.locator('#mensaje').innerText();
const tipoMensaje = () => pagina.locator('#mensaje').getAttribute('data-tipo');
async function entrar(usuario) {
  await pagina.fill('#login [name=login]', usuario);
  await pagina.fill('#login [name=password]', CLAVE);
  await pagina.click('#login button');
  await pagina.waitForSelector('#aplicacion:not([hidden])');
}
async function abrir(clave, titulo) {
  await pagina.click(`#menu a[data-pantalla="${clave}"]`);
  await pagina.waitForFunction(t => document.querySelector('#vista h1')?.textContent === t, titulo);
  await quieto();
}
async function elegirEmpleado(formulario, texto) {
  const buscador = formulario.locator('.selector-empleado input[type=search]').first();
  await buscador.fill(texto);
  await formulario.locator('.selector-empleado li[role=option]').first().waitFor();
  await buscador.press('Enter');
}
async function enviar(formulario) {
  await formulario.locator('button:not([type=button])').first().click();
  await quieto();
}

try {
  await pagina.goto(URL_BASE);
  await pagina.waitForSelector('#acceso:not([hidden])');
  await pagina.screenshot({ path: CAPTURAS + '00-acceso.png' });
  ok('sin sesión se muestra el acceso');

  // Credenciales erróneas
  await pagina.fill('#login [name=login]', 'operador');
  await pagina.fill('#login [name=password]', 'incorrecta');
  await pagina.click('#login button');
  await pagina.waitForFunction(() => document.querySelector('#mensaje').textContent.length > 0);
  await verificar('credenciales erróneas muestran error', (await tipoMensaje()) === 'error');

  // Operador con todos los permisos
  await entrar('operador');
  const modulos = await pagina.locator('#menu .menu-modulo h2').allTextContents();
  await verificar('operador ve 5 módulos en orden: ' + modulos.join(' | '),
    modulos.join('|') === 'Gestión de turnos|Permisos y licencias|Vacaciones|Teletrabajo y presencialidad|Reportes generales');
  await verificar('ningún texto dice «piloto»', !(await pagina.locator('body').innerText()).toLowerCase().includes('piloto'));
  await pagina.screenshot({ path: CAPTURAS + '01-inicio.png' });

  const pantallas = await pagina.locator('#menu a[data-pantalla]').evaluateAll(as => as.map(a => [a.dataset.pantalla, a.textContent]));
  let n = 2;
  for (const [clave, titulo] of pantallas) {
    await abrir(clave, titulo);
    await verificar(`abre «${titulo}» sin error`, (await tipoMensaje()) !== 'error');
    await pagina.screenshot({ path: CAPTURAS + `${String(n++).padStart(2, '0')}-${clave}.png`, fullPage: true });
  }

  // RF-01: asignar turno con el buscador y editar
  await abrir('asignar-turno', 'Asignar turno por periodo');
  let form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'fic');
  await verificar('el buscador muestra código y documento', (await form.locator('.ayuda').innerText()).includes('Código'));
  await form.locator('[name=horario]').selectOption({ index: 1 });
  await form.locator('[name=desde]').fill('2026-12-01');
  await form.locator('[name=hasta]').fill('2026-12-15');
  await enviar(form);
  await verificar('RF-01 guarda la asignación: ' + await mensaje(), (await tipoMensaje()) === 'exito');
  await verificar('RF-01 lista la asignación del empleado', (await pagina.locator('#vista table tbody tr').count()) === 1);
  await pagina.locator('#vista table button', { hasText: 'Editar' }).click();
  await quieto();
  await verificar('RF-01 «Editar» carga el periodo', (await form.locator('[name=desde]').inputValue()) === '2026-12-01');
  await pagina.screenshot({ path: CAPTURAS + '20-rf01-editando.png', fullPage: true });
  await form.locator('[data-nuevo]').click();
  await form.locator('[name=horario]').selectOption({ index: 1 });
  await form.locator('[name=desde]').fill('2026-12-10');
  await form.locator('[name=hasta]').fill('2026-12-20');
  await enviar(form);
  await verificar('RF-01 rechaza un periodo solapado: ' + await mensaje(), (await tipoMensaje()) === 'error');

  // Selector: texto sin elegir de la lista no se envía
  await abrir('historico-turnos', 'Histórico de turnos');
  form = pagina.locator('#vista form').first();
  await form.locator('input[type=search]').fill('zzz');
  await enviar(form);
  await verificar('el selector exige elegir un empleado de la lista',
    await form.locator('input[type=search]').evaluate(e => !e.checkValidity()));
  await elegirEmpleado(form, '0000');
  await enviar(form);
  await verificar('RF-02 muestra el histórico', (await pagina.locator('#vista table tbody tr').count()) === 1);

  // RF-13: periodo parcial y rechazo por solapamiento
  await abrir('periodos-teletrabajo', 'Periodos de teletrabajo');
  form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'operador');
  await form.locator('[name=modalidad]').selectOption('P');
  await form.locator('input[name=dia][value="1"]').check();
  await form.locator('input[name=dia][value="4"]').check();
  await form.locator('[name=desde]').fill('2026-11-09');
  await form.locator('[name=hasta]').fill('2026-11-13');
  await enviar(form);
  await verificar('RF-13 registra el periodo: ' + await mensaje(), (await tipoMensaje()) === 'exito');
  await verificar('RF-13 lista el patrón Lun, Mié', (await pagina.locator('#vista table').innerText()).includes('Lun, Mié'));
  await enviar(form);
  await verificar('RF-13 rechaza el solapamiento: ' + await mensaje(), (await tipoMensaje()) === 'error');
  await pagina.screenshot({ path: CAPTURAS + '21-rf13-solapamiento.png', fullPage: true });

  // RF-14 y RF-16 con el periodo recién creado
  await abrir('dias-teletrabajo', 'Días de teletrabajo');
  form = pagina.locator('#vista form').first();
  await form.locator('[name=desde]').fill('2026-11-09');
  await form.locator('[name=hasta]').fill('2026-11-15');
  await enviar(form);
  const filasDias = await pagina.locator('#vista tbody tr').allInnerTexts();
  // Patrón lunes y miércoles del 9 al 15/11: el lunes 9 cuenta y el miércoles 11 es feriado ficticio.
  await verificar('RF-14 descuenta el feriado del 11/11 (1 día): ' + filasDias.join(' / '), filasDias.some(f => /^101\s+1$/.test(f.trim())));
  await abrir('teletrabajo-total-parcial', 'Teletrabajo total o parcial');
  form = pagina.locator('#vista form').first();
  await form.locator('[name=desde]').fill('2026-11-09');
  await form.locator('[name=hasta]').fill('2026-11-13');
  await enviar(form);
  await verificar('RF-16 clasifica como Parcial', (await pagina.locator('#vista table').innerText()).includes('Parcial'));

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
  await pagina.screenshot({ path: CAPTURAS + '22-rf03-mismo-dia.png', fullPage: true });

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

  // RF-07 y RF-09
  await abrir('vacaciones-generadas', 'Vacaciones generadas');
  form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'fic');
  await form.locator('[name=corte]').fill('2026-11-20');
  await enviar(form);
  await verificar('RF-07 genera 60 días por dos aniversarios', (await pagina.locator('#vista .indicadores').innerText()).includes('60'));
  await pagina.screenshot({ path: CAPTURAS + '23-rf07.png', fullPage: true });
  await abrir('vacaciones-truncas', 'Vacaciones truncas');
  form = pagina.locator('#vista form').first();
  await elegirEmpleado(form, 'fic');
  await form.locator('[name=cese]').fill('2026-11-20');
  await enviar(form);
  await verificar('RF-09 calcula 21,67 días truncos', (await pagina.locator('#vista .indicadores').innerText()).includes('21.67'));

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
  await pagina.screenshot({ path: CAPTURAS + '24-rf18.png', fullPage: true });

  // Enlace directo y ruta inexistente
  await pagina.goto(URL_BASE + '/#/no-existe');
  await pagina.waitForFunction(() => document.querySelector('#vista h1')?.textContent === 'Inicio');
  await verificar('una ruta inexistente vuelve al inicio con aviso', (await tipoMensaje()) === 'error');

  // Salir
  await pagina.click('#salir');
  await pagina.waitForSelector('#acceso:not([hidden])');
  ok('cerrar sesión vuelve al acceso');

  // Rol solo teletrabajo
  await entrar('solo_teletrabajo');
  const soloModulos = await pagina.locator('#menu .menu-modulo h2').allTextContents();
  const soloPantallas = await pagina.locator('#menu a[data-pantalla]').allInnerTexts();
  await verificar('solo_teletrabajo ve solo su módulo: ' + soloPantallas.join(', '),
    soloModulos.join('|') === 'Teletrabajo y presencialidad' && soloPantallas.length === 3);
  await pagina.goto(URL_BASE + '/#/saldo-vacaciones');
  await pagina.waitForFunction(() => document.querySelector('#vista h1')?.textContent === 'Inicio');
  await verificar('solo_teletrabajo no puede abrir vacaciones por enlace directo', (await tipoMensaje()) === 'error');

  // Celular
  await pagina.setViewportSize({ width: 390, height: 844 });
  await pagina.goto(URL_BASE + '/#/periodos-teletrabajo');
  await pagina.waitForFunction(() => document.querySelector('#vista h1')?.textContent === 'Periodos de teletrabajo');
  await verificar('en celular el menú empieza cerrado', !(await pagina.locator('#menu').isVisible()));
  await pagina.screenshot({ path: CAPTURAS + '30-celular.png', fullPage: true });
  await pagina.click('#abrir-menu');
  await verificar('el botón Menú lo abre', await pagina.locator('#menu').isVisible());
  await pagina.screenshot({ path: CAPTURAS + '31-celular-menu.png' });
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
