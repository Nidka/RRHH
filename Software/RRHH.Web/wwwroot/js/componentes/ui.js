// Piezas visuales pequeñas y reutilizables. Todo texto se asigna con textContent.

const SVG = 'http://www.w3.org/2000/svg';

/** Ícono del sprite de index.html (por ejemplo, icono('turnos') usa #i-turnos). */
export function icono(nombre) {
  const svg = document.createElementNS(SVG, 'svg');
  svg.setAttribute('class', 'icono');
  svg.setAttribute('aria-hidden', 'true');
  const uso = document.createElementNS(SVG, 'use');
  uso.setAttribute('href', '#i-' + nombre);
  svg.append(uso);
  return svg;
}

/** Etiqueta de estado. tono: 'marca' | 'cian' | 'exito' | 'aviso' | 'peligro' | '' (neutro). */
export function chip(texto, tono = '') {
  const elemento = document.createElement('span');
  elemento.className = 'chip' + (tono ? ' ' + tono : '');
  elemento.textContent = texto;
  return elemento;
}

/** Hasta dos iniciales a partir de «Apellidos, Nombres» o de un texto libre. */
export function iniciales(nombre) {
  const [apellidos = '', nombres = ''] = String(nombre || '').split(',');
  const primera = (nombres.trim() || apellidos.trim()).charAt(0);
  const segunda = apellidos.trim().charAt(0);
  return ((nombres.trim() ? primera + segunda : primera) || '?').toUpperCase();
}

const TONOS_AVATAR = ['#5b5bf6', '#0ea5e9', '#f43f5e', '#10b981', '#8b5cf6', '#f59e0b', '#14b8a6'];

/** Avatar circular con iniciales; el color depende del código para ser estable entre pantallas. */
export function avatar(nombre, codigo = 0) {
  const elemento = document.createElement('span');
  elemento.className = 'avatar';
  elemento.setAttribute('aria-hidden', 'true');
  elemento.textContent = iniciales(nombre);
  elemento.style.background = TONOS_AVATAR[Math.abs(Number(codigo) || 0) % TONOS_AVATAR.length];
  return elemento;
}

/** Celda de persona: avatar, nombre y un detalle (por ejemplo, «código 101»). */
export function persona(nombre, detalle, codigo) {
  const caja = document.createElement('div');
  caja.className = 'persona';
  const texto = document.createElement('div');
  texto.append(nombre || `Empleado ${codigo}`);
  if (detalle) {
    const pequeno = document.createElement('small');
    pequeno.textContent = detalle;
    texto.append(pequeno);
  }
  caja.append(avatar(nombre || String(codigo), codigo), texto);
  return caja;
}

/** Estado vacío con ícono y texto. */
export function vacio(texto, nombreIcono = 'info') {
  const parrafo = document.createElement('p');
  parrafo.className = 'vacio';
  const span = document.createElement('span');
  span.textContent = texto;
  parrafo.append(icono(nombreIcono), span);
  return parrafo;
}

/** Botón secundario pequeño para acciones dentro de una tabla. */
export function botonFila(texto, alPulsar) {
  const boton = document.createElement('button');
  boton.type = 'button';
  boton.className = 'btn btn-secundario btn-chico';
  boton.textContent = texto;
  boton.addEventListener('click', alPulsar);
  return boton;
}
