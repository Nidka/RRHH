// Tabla de resultados e indicadores reutilizables. Los datos se insertan como texto, nunca como HTML.

import { icono, vacio as estadoVacio } from './ui.js';

/**
 * Dibuja una tabla en el contenedor. filas: arreglo de arreglos con los valores de cada columna;
 * un valor puede ser un nodo ya construido (por ejemplo, una etiqueta o un botón de acción).
 * vacio: texto que se muestra cuando no hay filas.
 */
export function tabla(contenedor, columnas, filas, vacio = 'No se encontraron resultados.') {
  contenedor.replaceChildren();
  if (!filas.length) {
    contenedor.append(estadoVacio(vacio));
    return;
  }
  const elemento = document.createElement('table');
  const encabezado = elemento.createTHead().insertRow();
  for (const columna of columnas) {
    const th = document.createElement('th');
    th.scope = 'col';
    th.textContent = columna;
    encabezado.append(th);
  }
  const cuerpo = elemento.createTBody();
  for (const fila of filas) {
    const tr = cuerpo.insertRow();
    for (const dato of fila) {
      const celda = tr.insertCell();
      if (dato instanceof Node) celda.append(dato); else celda.textContent = dato ?? '';
    }
  }
  contenedor.append(elemento);
}

/**
 * Tarjetas de indicadores. pares: [etiqueta, valor, opciones?] donde opciones admite
 * { icono, tono: 'cian' | 'exito' | 'aviso' | 'peligro', detalle }.
 */
export function indicadores(contenedor, pares) {
  contenedor.replaceChildren();
  for (const [etiqueta, valor, opciones = {}] of pares) {
    const tarjeta = document.createElement('div');
    tarjeta.className = 'indicador' + (opciones.tono ? ' ' + opciones.tono : '');
    const cabeza = document.createElement('div');
    cabeza.className = 'indicador-cabeza';
    const caja = document.createElement('span');
    caja.className = 'indicador-icono';
    caja.append(icono(opciones.icono || 'reportes'));
    const texto = document.createElement('span');
    texto.textContent = etiqueta;
    cabeza.append(caja, texto);
    const numero = document.createElement('strong');
    numero.textContent = valor ?? '—';
    tarjeta.append(cabeza, numero);
    if (opciones.detalle) {
      const detalle = document.createElement('small');
      detalle.textContent = opciones.detalle;
      tarjeta.append(detalle);
    }
    contenedor.append(tarjeta);
  }
}
