// Tabla de resultados reutilizable. Los datos se insertan como texto, nunca como HTML.

/**
 * Dibuja una tabla en el contenedor. filas: arreglo de arreglos con los valores de cada columna;
 * un valor puede ser un nodo ya construido (por ejemplo, un botón de acción).
 * vacio: texto que se muestra cuando no hay filas.
 */
export function tabla(contenedor, columnas, filas, vacio = 'No se encontraron resultados.') {
  contenedor.replaceChildren();
  if (!filas.length) {
    const aviso = document.createElement('p');
    aviso.className = 'vacio';
    aviso.textContent = vacio;
    contenedor.append(aviso);
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

/** Muestra indicadores clave (etiqueta y valor) sobre una tabla o un resultado. */
export function indicadores(contenedor, pares) {
  contenedor.replaceChildren();
  for (const [etiqueta, valor] of pares) {
    const tarjeta = document.createElement('div');
    tarjeta.className = 'indicador';
    const numero = document.createElement('strong');
    numero.textContent = valor ?? '—';
    const texto = document.createElement('span');
    texto.textContent = etiqueta;
    tarjeta.append(numero, texto);
    contenedor.append(tarjeta);
  }
}
