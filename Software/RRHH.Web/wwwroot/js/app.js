// Arranque de la aplicación web: sesión, menú por módulos y carga de cada pantalla (CR-019).
// Cada pantalla vive en js/modulos/<módulo>/<pantalla>.js y exporta montar(contenedor).
// Agregar una pantalla = crear su archivo y su entrada en CatalogoModulos; este archivo no cambia.

import { api, alExpirarSesion } from './componentes/api.js';
import { mostrar, exito, limpiar } from './componentes/mensajes.js';
import { alEnviar } from './componentes/formulario.js';
import { dibujarMenu, marcarActiva, encabezado, dibujarInicio } from './componentes/navegacion.js';

const $ = id => document.getElementById(id);
const CLAVE_VALIDA = /^[a-z0-9]+(-[a-z0-9]+)*$/;

let modulos = [];
let usuario = '';
let montaje = 0;

function mostrarAcceso() {
  modulos = [];
  $('acceso').hidden = false;
  $('aplicacion').hidden = true;
  $('salir').hidden = true;
  $('usuario').textContent = '';
  $('menu').replaceChildren();
  $('vista').replaceChildren();
  $('login').elements.login.focus();
}

function ubicar(clave) {
  for (const modulo of modulos) {
    const pantalla = modulo.pantallas.find(p => p.clave === clave);
    if (pantalla) return { modulo, pantalla };
  }
  return null;
}

async function mostrarRuta() {
  if (!modulos.length && $('aplicacion').hidden) return;
  const clave = location.hash.replace(/^#\/?/, '');
  const vista = $('vista');
  const numero = ++montaje;
  limpiar();
  marcarActiva($('menu'), clave);
  document.body.classList.remove('menu-abierto');
  const destino = clave && ubicar(clave);
  if (!destino) {
    dibujarInicio(vista, modulos, usuario);
    if (clave) mostrar('La pantalla solicitada no existe o su rol no la tiene habilitada.', 'error');
    vista.querySelector('h1').focus();
    return;
  }
  const { modulo, pantalla } = destino;
  if (!CLAVE_VALIDA.test(modulo.clave) || !CLAVE_VALIDA.test(pantalla.clave)) return;
  try {
    const { montar } = await import(`./modulos/${modulo.clave}/${pantalla.clave}.js`);
    if (numero !== montaje) return;
    const cuerpo = document.createElement('div');
    cuerpo.className = 'cuerpo-pantalla';
    vista.replaceChildren(encabezado(modulo, pantalla), cuerpo);
    document.title = `${pantalla.titulo} · RRHH`;
    await montar(cuerpo);
    if (numero === montaje) vista.querySelector('h1').focus();
  } catch (falla) {
    if (numero === montaje) mostrar('No se pudo abrir la pantalla: ' + falla.message, 'error');
  }
}

async function cargarSesion() {
  const sesion = await api('sesion');
  usuario = sesion.usuario;
  modulos = await api('modulos');
  $('usuario').textContent = usuario;
  $('acceso').hidden = true;
  $('aplicacion').hidden = false;
  $('salir').hidden = false;
  dibujarMenu($('menu'), modulos);
  // La autoconsulta tiene una sola pantalla: se abre directamente.
  if (!location.hash && sesion.autoconsulta && modulos.length === 1 && modulos[0].pantallas.length === 1)
    location.hash = `#/${modulos[0].pantallas[0].clave}`;
  else
    await mostrarRuta();
}

alExpirarSesion(() => { mostrarAcceso(); });

alEnviar($('login'), async datos => {
  try { await api('login', Object.fromEntries(datos)); }
  finally { $('login').reset(); }
  await cargarSesion();
});

$('salir').addEventListener('click', async () => {
  try {
    await api('salir', {});
    history.replaceState(null, '', '/');
    mostrarAcceso();
    exito('Sesión cerrada.');
  } catch (falla) {
    mostrar(falla.message, 'error');
  }
});

$('abrir-menu').addEventListener('click', () => document.body.classList.toggle('menu-abierto'));
window.addEventListener('hashchange', mostrarRuta);

cargarSesion().catch(() => mostrarAcceso());
