// Gráficos livianos en SVG y CSS, sin bibliotecas externas (la política CSP solo admite el mismo origen).

import { vacio } from './ui.js';
import { mostrarFecha } from './fechas.js';

const SVG = 'http://www.w3.org/2000/svg';
export const COLORES = ['#5b5bf6', '#22c3e6', '#a78bfa', '#f59e0b', '#10b981', '#f43f5e', '#64748b'];

/**
 * Dona con leyenda. segmentos: [{ etiqueta, valor, color? }]. centro: { valor, texto } para el número del medio.
 */
export function dona(contenedor, segmentos, centro) {
  contenedor.replaceChildren();
  const total = segmentos.reduce((suma, s) => suma + s.valor, 0);
  if (!total) { contenedor.append(vacio('Sin datos para graficar.')); return; }
  const caja = document.createElement('div');
  caja.className = 'dona';
  const figura = document.createElement('div');
  figura.className = 'dona-figura';
  const svg = document.createElementNS(SVG, 'svg');
  svg.setAttribute('viewBox', '0 0 42 42');
  svg.setAttribute('role', 'img');
  svg.setAttribute('aria-label', segmentos.map(s => `${s.etiqueta}: ${s.valor}`).join(', '));
  const fondo = document.createElementNS(SVG, 'circle');
  Object.entries({ cx: 21, cy: 21, r: 15.915, fill: 'none', 'stroke-width': 6 }).forEach(([k, v]) => fondo.setAttribute(k, v));
  fondo.style.stroke = 'var(--linea)'; // como estilo: un atributo SVG no resuelve variables CSS
  svg.append(fondo);
  let acumulado = 0;
  segmentos.forEach((s, i) => {
    if (!s.valor) return;
    const porcentaje = s.valor / total * 100;
    const arco = document.createElementNS(SVG, 'circle');
    Object.entries({ cx: 21, cy: 21, r: 15.915, fill: 'none', stroke: s.color || COLORES[i % COLORES.length], 'stroke-width': 6,
      'stroke-dasharray': `${Math.max(porcentaje - 0.8, 0.5)} ${100 - Math.max(porcentaje - 0.8, 0.5)}`, 'stroke-dashoffset': -acumulado })
      .forEach(([k, v]) => arco.setAttribute(k, v));
    svg.append(arco);
    acumulado += porcentaje;
  });
  const medio = document.createElement('div');
  medio.className = 'dona-centro';
  const numero = document.createElement('strong');
  numero.textContent = centro?.valor ?? total;
  const texto = document.createElement('small');
  texto.textContent = centro?.texto ?? 'total';
  medio.append(numero, texto);
  figura.append(svg, medio);
  const leyenda = document.createElement('ul');
  leyenda.className = 'leyenda';
  segmentos.forEach((s, i) => {
    const item = document.createElement('li');
    const color = document.createElement('i');
    color.style.background = s.color || COLORES[i % COLORES.length];
    const valor = document.createElement('b');
    valor.textContent = s.valor;
    item.append(color, s.etiqueta, valor);
    leyenda.append(item);
  });
  caja.append(figura, leyenda);
  contenedor.append(caja);
}

/** Barras horizontales ordenadas. filas: [{ etiqueta, valor, texto? }]; texto reemplaza al número mostrado. */
export function barras(contenedor, filas, vacioTexto = 'Sin datos para graficar.') {
  contenedor.replaceChildren();
  if (!filas.length) { contenedor.append(vacio(vacioTexto)); return; }
  const maximo = Math.max(...filas.map(f => f.valor), 1);
  const lista = document.createElement('div');
  lista.className = 'barras';
  for (const fila of filas) {
    const renglon = document.createElement('div');
    renglon.className = 'barra-fila';
    const nombre = document.createElement('span');
    nombre.textContent = fila.etiqueta;
    nombre.title = fila.etiqueta;
    const riel = document.createElement('div');
    riel.className = 'riel';
    const relleno = document.createElement('i');
    relleno.style.width = `${fila.valor / maximo * 100}%`;
    riel.append(relleno);
    const valor = document.createElement('b');
    valor.textContent = fila.texto ?? fila.valor;
    renglon.append(nombre, riel, valor);
    lista.append(renglon);
  }
  contenedor.append(lista);
}

/** Barra de progreso para una celda o tarjeta: valor sobre máximo con un texto a la derecha. */
export function progreso(valor, maximo, texto) {
  const caja = document.createElement('div');
  caja.className = 'progreso';
  const riel = document.createElement('div');
  riel.className = 'riel';
  const relleno = document.createElement('i');
  relleno.style.width = `${maximo > 0 ? Math.min(valor / maximo, 1) * 100 : 0}%`;
  riel.append(relleno);
  const etiqueta = document.createElement('small');
  etiqueta.textContent = texto ?? `${valor} / ${maximo}`;
  caja.append(riel, etiqueta);
  return caja;
}

const DIAS = ['Lun', 'Mar', 'Mié', 'Jue', 'Vie', 'Sáb', 'Dom'];

/**
 * Calendario por semanas. dias: [{ fecha: 'yyyy-MM-dd…', clase: 'marca' | 'cian' | 'aviso' | 'peligro' | 'gris' | '', titulo }].
 */
export function calendario(contenedor, dias) {
  contenedor.replaceChildren();
  if (!dias.length) { contenedor.append(vacio('Sin días en el periodo.')); return; }
  const rejilla = document.createElement('div');
  rejilla.className = 'calendario';
  for (const nombre of DIAS) {
    const cabeza = document.createElement('span');
    cabeza.className = 'dia-semana';
    cabeza.textContent = nombre;
    rejilla.append(cabeza);
  }
  const primero = new Date(dias[0].fecha.slice(0, 10) + 'T00:00:00');
  const desplazamiento = (primero.getDay() + 6) % 7;
  for (let i = 0; i < desplazamiento; i++) {
    const hueco = document.createElement('span');
    hueco.className = 'dia vacio-dia';
    rejilla.append(hueco);
  }
  for (const dia of dias) {
    const celda = document.createElement('span');
    celda.className = 'dia' + (dia.clase ? ' ' + dia.clase : '');
    celda.textContent = Number(dia.fecha.slice(8, 10));
    celda.title = `${mostrarFecha(dia.fecha)}${dia.titulo ? ' · ' + dia.titulo : ''}`;
    rejilla.append(celda);
  }
  contenedor.append(rejilla);
}

/**
 * Línea de tiempo de periodos. tramos: [{ desde, hasta, texto, color? }] con fechas de la API.
 * Ajusta la escala al primer y último día de los tramos y marca el inicio de cada mes.
 */
export function lineaTiempo(contenedor, tramos) {
  contenedor.replaceChildren();
  const validos = tramos.filter(t => t.desde && t.hasta);
  if (!validos.length) return;
  const dia = valor => new Date(valor.slice(0, 10) + 'T00:00:00').getTime();
  const DIA_MS = 86400000;
  const inicio = new Date(Math.min(...validos.map(t => dia(t.desde))));
  inicio.setDate(1);
  const fin = new Date(Math.max(...validos.map(t => dia(t.hasta))));
  const finEscala = new Date(fin.getFullYear(), fin.getMonth() + 1, 1).getTime();
  const ancho = finEscala - inicio.getTime();
  const posicion = momento => (momento - inicio.getTime()) / ancho * 100;
  const caja = document.createElement('div');
  caja.className = 'linea-tiempo';
  const meses = document.createElement('div');
  meses.className = 'linea-meses';
  const formato = new Intl.DateTimeFormat('es-PE', { month: 'short', year: 'numeric' });
  for (let mes = new Date(inicio); mes.getTime() < finEscala; mes.setMonth(mes.getMonth() + 1)) {
    const marca = document.createElement('span');
    marca.style.left = `${posicion(mes.getTime())}%`;
    marca.textContent = formato.format(mes);
    meses.append(marca);
  }
  const pista = document.createElement('div');
  pista.className = 'linea-pista';
  validos.forEach((t, i) => {
    const tramo = document.createElement('span');
    tramo.className = 'tramo';
    tramo.style.left = `${posicion(dia(t.desde))}%`;
    tramo.style.width = `${(dia(t.hasta) + DIA_MS - dia(t.desde)) / ancho * 100}%`;
    tramo.style.background = t.color || COLORES[i % COLORES.length];
    tramo.textContent = t.texto;
    tramo.title = `${t.texto}: ${mostrarFecha(t.desde)} – ${mostrarFecha(t.hasta)}`;
    pista.append(tramo);
  });
  caja.append(meses, pista);
  contenedor.append(caja);
}
