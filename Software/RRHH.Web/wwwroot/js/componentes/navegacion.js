// Navegación por módulos: se arma con lo que devuelve /api/modulos, ya filtrado por los permisos de la sesión.

const enlace = pantalla => `#/${pantalla.clave}`;

function insignias(requerimientos) {
  const grupo = document.createElement('span');
  grupo.className = 'insignias';
  for (const rf of requerimientos) {
    const insignia = document.createElement('span');
    insignia.className = 'insignia';
    insignia.textContent = rf;
    grupo.append(insignia);
  }
  return grupo;
}

/** Dibuja el menú lateral agrupado por módulo. */
export function dibujarMenu(contenedor, modulos) {
  contenedor.replaceChildren();
  const inicio = document.createElement('a');
  inicio.href = '#/';
  inicio.className = 'menu-inicio';
  inicio.textContent = 'Inicio';
  contenedor.append(inicio);
  for (const modulo of modulos) {
    const grupo = document.createElement('section');
    grupo.className = 'menu-modulo';
    const titulo = document.createElement('h2');
    titulo.textContent = modulo.titulo;
    const lista = document.createElement('ul');
    for (const pantalla of modulo.pantallas) {
      const item = document.createElement('li');
      const a = document.createElement('a');
      a.href = enlace(pantalla);
      a.dataset.pantalla = pantalla.clave;
      a.textContent = pantalla.titulo;
      item.append(a);
      lista.append(item);
    }
    grupo.append(titulo, lista);
    contenedor.append(grupo);
  }
}

/** Marca en el menú la pantalla activa (o Inicio si no hay ninguna). */
export function marcarActiva(contenedor, clave) {
  for (const a of contenedor.querySelectorAll('a')) {
    const activa = clave ? a.dataset.pantalla === clave : a.classList.contains('menu-inicio');
    if (activa) a.setAttribute('aria-current', 'page'); else a.removeAttribute('aria-current');
  }
}

/** Encabezado de la pantalla: módulo, título y requerimientos que atiende. */
export function encabezado(modulo, pantalla) {
  const cabecera = document.createElement('header');
  cabecera.className = 'cabecera-pantalla';
  const ruta = document.createElement('p');
  ruta.className = 'ruta';
  ruta.textContent = modulo.titulo;
  const titulo = document.createElement('h1');
  titulo.textContent = pantalla.titulo;
  titulo.tabIndex = -1;
  cabecera.append(ruta, titulo, insignias(pantalla.requerimientos));
  return cabecera;
}

/** Vista de inicio: un resumen de los módulos habilitados con acceso directo a cada pantalla. */
export function dibujarInicio(contenedor, modulos, usuario) {
  contenedor.replaceChildren();
  const cabecera = document.createElement('header');
  cabecera.className = 'cabecera-pantalla';
  const titulo = document.createElement('h1');
  titulo.textContent = 'Inicio';
  titulo.tabIndex = -1;
  const saludo = document.createElement('p');
  saludo.className = 'ruta';
  saludo.textContent = `Sesión de ${usuario}. Elija una pantalla del menú o de los módulos.`;
  cabecera.append(saludo, titulo);
  const rejilla = document.createElement('div');
  rejilla.className = 'rejilla-modulos';
  for (const modulo of modulos) {
    const tarjeta = document.createElement('article');
    tarjeta.className = 'tarjeta-modulo';
    const nombre = document.createElement('h2');
    nombre.textContent = modulo.titulo;
    const lista = document.createElement('ul');
    for (const pantalla of modulo.pantallas) {
      const item = document.createElement('li');
      const a = document.createElement('a');
      a.href = enlace(pantalla);
      a.textContent = pantalla.titulo;
      item.append(a, insignias(pantalla.requerimientos));
      lista.append(item);
    }
    tarjeta.append(nombre, lista);
    rejilla.append(tarjeta);
  }
  if (!modulos.length) {
    const aviso = document.createElement('p');
    aviso.textContent = 'Su rol no tiene módulos habilitados. Solicite el acceso a RRHH.';
    rejilla.append(aviso);
  }
  contenedor.append(cabecera, rejilla);
}
