// Búsqueda rápida de pantallas (Ctrl K o ⌘K). Solo lista las pantallas habilitadas para la sesión.

import { icono } from './ui.js';
import { ESTILO_MODULO } from './navegacion.js';

const $ = id => document.getElementById(id);
let opciones = [];
let activa = 0;
let visibles = [];
let alCerrarFoco = null;

const normalizar = texto => texto.normalize('NFD').replace(/[̀-ͯ]/g, '').toLowerCase();

/** Define las pantallas disponibles a partir de los módulos de la sesión. */
export function prepararPaleta(modulos) {
  opciones = modulos.flatMap(m => m.pantallas.map(p => ({ modulo: m, pantalla: p,
    busqueda: normalizar(`${p.titulo} ${m.titulo} ${p.requerimientos.join(' ')}`) })));
}

function dibujar() {
  const lista = $('paleta-lista');
  const consulta = normalizar($('paleta-texto').value.trim());
  visibles = opciones.filter(o => !consulta || consulta.split(/\s+/).every(t => o.busqueda.includes(t)));
  activa = Math.min(activa, Math.max(visibles.length - 1, 0));
  lista.replaceChildren();
  visibles.forEach((o, i) => {
    const item = document.createElement('li');
    item.id = `paleta-opcion-${i}`;
    item.setAttribute('role', 'option');
    item.setAttribute('aria-selected', String(i === activa));
    const textos = document.createElement('div');
    const titulo = document.createElement('b');
    titulo.textContent = o.pantalla.titulo;
    const detalle = document.createElement('small');
    detalle.textContent = `${o.modulo.titulo} · ${o.pantalla.requerimientos.join(', ')}`;
    textos.append(titulo, detalle);
    item.append(icono(ESTILO_MODULO[o.modulo.clave]?.icono || 'reportes'), textos);
    item.addEventListener('mousedown', evento => { evento.preventDefault(); ir(o); });
    lista.append(item);
  });
  if (!visibles.length) {
    const vacio = document.createElement('li');
    vacio.textContent = 'Ninguna pantalla coincide.';
    lista.append(vacio);
  }
  $('paleta-texto').setAttribute('aria-activedescendant', visibles.length ? `paleta-opcion-${activa}` : '');
}

function ir(opcion) {
  cerrarPaleta();
  location.hash = `#/${opcion.pantalla.clave}`;
}

export function abrirPaleta() {
  if (!opciones.length) return;
  alCerrarFoco = document.activeElement;
  $('paleta').hidden = false;
  $('paleta-texto').value = '';
  activa = 0;
  dibujar();
  $('paleta-texto').focus();
}

export function cerrarPaleta() {
  if ($('paleta').hidden) return;
  $('paleta').hidden = true;
  alCerrarFoco?.focus?.();
}

/** Conecta los eventos de teclado y ratón una sola vez. */
export function iniciarPaleta() {
  $('paleta-texto').addEventListener('input', () => { activa = 0; dibujar(); });
  $('paleta-texto').addEventListener('keydown', evento => {
    if (evento.key === 'ArrowDown') { evento.preventDefault(); activa = Math.min(activa + 1, visibles.length - 1); dibujar(); }
    else if (evento.key === 'ArrowUp') { evento.preventDefault(); activa = Math.max(activa - 1, 0); dibujar(); }
    else if (evento.key === 'Enter' && visibles[activa]) { evento.preventDefault(); ir(visibles[activa]); }
  });
  $('paleta').addEventListener('mousedown', evento => { if (evento.target === $('paleta')) cerrarPaleta(); });
  document.addEventListener('keydown', evento => {
    if ((evento.ctrlKey || evento.metaKey) && evento.key.toLowerCase() === 'k' && !$('aplicacion').hidden) {
      evento.preventDefault();
      abrirPaleta();
    } else if (evento.key === 'Escape') {
      cerrarPaleta();
    }
  });
}
