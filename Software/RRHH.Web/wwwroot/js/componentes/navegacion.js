// Navegación por módulos: se arma con lo que devuelve /api/modulos, ya filtrado por los permisos de la sesión.

import { api } from './api.js';
import { icono } from './ui.js';
import { indicadores } from './tabla.js';
import { dona, barras } from './graficos.js';
import { hoy, inicioDeMes } from './fechas.js';

/** Ícono y color de cada módulo del catálogo (clave de CatalogoModulos). */
export const ESTILO_MODULO = {
  'turnos': { icono: 'turnos', fondo: 'linear-gradient(135deg,#5b5bf6,#8b5cf6)' },
  'permisos': { icono: 'permisos', fondo: 'linear-gradient(135deg,#f43f5e,#f59e0b)' },
  'vacaciones': { icono: 'vacaciones', fondo: 'linear-gradient(135deg,#10b981,#22c3e6)' },
  'teletrabajo': { icono: 'teletrabajo', fondo: 'linear-gradient(135deg,#0ea5e9,#6366f1)' },
  'reportes': { icono: 'reportes', fondo: 'linear-gradient(135deg,#8b5cf6,#ec4899)' },
  'personal': { icono: 'personas', fondo: 'linear-gradient(135deg,#f59e0b,#f43f5e)' },
  'mi-cuenta': { icono: 'cuenta', fondo: 'linear-gradient(135deg,#14b8a6,#5b5bf6)' }
};
const estilo = clave => ESTILO_MODULO[clave] || { icono: 'reportes', fondo: 'var(--degradado)' };
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

/** Dibuja el menú lateral agrupado por módulo, con un ícono por pantalla. */
export function dibujarMenu(contenedor, modulos) {
  contenedor.replaceChildren();
  const inicio = document.createElement('a');
  inicio.href = '#/';
  inicio.className = 'menu-inicio';
  inicio.append(icono('inicio'), 'Inicio');
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
      a.append(icono(estilo(modulo.clave).icono), pantalla.titulo);
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

/** Migas de pan: RRHH › módulo › pantalla. */
export function dibujarMigas(contenedor, modulo, pantalla) {
  contenedor.replaceChildren();
  const raiz = document.createElement('a');
  raiz.href = '#/';
  raiz.textContent = 'RRHH';
  contenedor.append(raiz);
  for (const [texto, fuerte] of [[modulo?.titulo], [pantalla?.titulo ?? (modulo ? null : 'Inicio'), true]]) {
    if (!texto) continue;
    contenedor.append('›');
    const parte = document.createElement(fuerte ? 'b' : 'span');
    parte.textContent = texto;
    contenedor.append(parte);
  }
}

/** Encabezado de la pantalla: ícono del módulo, título y requerimientos que atiende. */
export function encabezado(modulo, pantalla) {
  const cabecera = document.createElement('header');
  cabecera.className = 'cabecera';
  const caja = document.createElement('span');
  caja.className = 'cabecera-icono';
  caja.append(icono(estilo(modulo.clave).icono));
  const textos = document.createElement('div');
  const ruta = document.createElement('p');
  ruta.className = 'ruta';
  ruta.textContent = modulo.titulo;
  const titulo = document.createElement('h1');
  titulo.tabIndex = -1;
  titulo.append(pantalla.titulo, ' ', insignias(pantalla.requerimientos));
  textos.append(ruta, titulo);
  cabecera.append(caja, textos);
  return cabecera;
}

function saludo() {
  const hora = new Date().getHours();
  return hora < 12 ? 'Buenos días' : hora < 19 ? 'Buenas tardes' : 'Buenas noches';
}

function tarjeta(titulo, subtitulo) {
  const caja = document.createElement('section');
  caja.className = 'tarjeta';
  const cabeza = document.createElement('div');
  cabeza.className = 'tarjeta-cabecera';
  const textos = document.createElement('div');
  const h2 = document.createElement('h2');
  h2.textContent = titulo;
  const p = document.createElement('p');
  p.textContent = subtitulo;
  textos.append(h2, p);
  cabeza.append(textos);
  const cuerpo = document.createElement('div');
  const esqueleto = document.createElement('div');
  esqueleto.className = 'esqueleto';
  esqueleto.style.height = '150px';
  cuerpo.append(esqueleto);
  caja.append(cabeza, cuerpo);
  return { caja, cuerpo };
}

/**
 * Vista de inicio. Cada indicador y gráfico se pide solo si la sesión tiene la pantalla correspondiente,
 * con las mismas rutas de la API que usan esas pantallas; un fallo se muestra en su tarjeta sin afectar al resto.
 */
export function dibujarInicio(contenedor, modulos, usuario) {
  contenedor.replaceChildren();
  const pantallas = new Set(modulos.flatMap(m => m.pantallas.map(p => p.clave)));
  const requerimientos = new Set(modulos.flatMap(m => m.pantallas.flatMap(p => p.requerimientos)));

  const portada = document.createElement('section');
  portada.className = 'portada';
  const h1 = document.createElement('h1');
  h1.tabIndex = -1;
  h1.textContent = `${saludo()}, ${usuario}`;
  const texto = document.createElement('p');
  texto.textContent = 'Resumen del mes en curso según los permisos de su rol. Los datos se consultan al abrir esta página.';
  const pildoras = document.createElement('div');
  pildoras.className = 'pildoras';
  for (const t of [`${modulos.length} ${modulos.length === 1 ? 'módulo habilitado' : 'módulos habilitados'}`,
    `${requerimientos.size} ${requerimientos.size === 1 ? 'requerimiento' : 'requerimientos'} a su alcance`]) {
    const span = document.createElement('span');
    span.textContent = t;
    pildoras.append(span);
  }
  portada.append(h1, texto, pildoras);
  contenedor.append(portada);

  const kpis = document.createElement('div');
  kpis.className = 'indicadores';
  contenedor.append(kpis);
  const pares = [];
  const graficos = document.createElement('div');
  graficos.className = 'rejilla columnas-2';
  contenedor.append(graficos);

  const mes = { desde: inicioDeMes(), hasta: hoy() };
  const tareas = [];
  if (pantallas.has('teletrabajo-total-parcial')) {
    const { caja, cuerpo } = tarjeta('Modalidad de teletrabajo', 'Personas con teletrabajo en el mes (RF-16)');
    graficos.append(caja);
    tareas.push(api(`clasificacion-teletrabajo?desde=${mes.desde}&hasta=${mes.hasta}`).then(filas => {
      const total = filas.filter(f => f.clasificacion === 0).length;
      pares.push(['En teletrabajo este mes', filas.length, { icono: 'teletrabajo', tono: 'cian', detalle: `${total} total · ${filas.length - total} parcial` }]);
      dona(cuerpo, [{ etiqueta: 'Total', valor: total }, { etiqueta: 'Parcial', valor: filas.length - total }], { valor: filas.length, texto: 'personas' });
    }).catch(falla => { cuerpo.textContent = falla.message; }));
  }
  if (pantallas.has('ausencias-periodo')) {
    const { caja, cuerpo } = tarjeta('Ausencias por motivo', 'Permisos y licencias que se cruzan con el mes (RF-18)');
    graficos.append(caja);
    tareas.push(api(`ausencias?desde=${mes.desde}&hasta=${mes.hasta}`).then(filas => {
      const porMotivo = new Map();
      for (const f of filas) porMotivo.set(f.motivo, (porMotivo.get(f.motivo) || 0) + 1);
      pares.push(['Personas con ausencias', new Set(filas.map(f => f.idEmpleado)).size, { icono: 'calendario', tono: 'aviso', detalle: `${filas.length} ausencias en el mes` }]);
      barras(cuerpo, [...porMotivo].sort((a, b) => b[1] - a[1]).map(([etiqueta, valor]) => ({ etiqueta, valor })), 'Nadie se ausenta este mes.');
    }).catch(falla => { cuerpo.textContent = falla.message; }));
  }
  if (pantallas.has('reporte-vacaciones')) {
    tareas.push(api(`vacaciones/reporte?anio=${new Date().getFullYear()}&corte=${hoy()}`).then(filas => {
      const completas = filas.filter(f => f.pendientes !== null && f.pendientes !== undefined);
      const pendientes = completas.reduce((s, f) => s + f.pendientes, 0);
      pares.push(['Vacaciones pendientes', `${pendientes.toLocaleString('es-PE')} días`, { icono: 'vacaciones', tono: 'exito',
        detalle: `${completas.length} de ${filas.length} personas con datos completos` }]);
    }).catch(() => {}));
  }
  if (pantallas.has('mis-vacaciones')) {
    tareas.push(api(`mi/vacaciones?corte=${hoy()}`).then(saldo => {
      pares.push(['Mis días pendientes', saldo.pendientes, { icono: 'vacaciones', tono: 'exito', detalle: `de ${saldo.generadas} generados` }]);
      pares.push(['Mis días usados', saldo.usadas, { icono: 'calendario', detalle: 'consumos aprobados' }]);
    }).catch(() => {}));
  }
  Promise.allSettled(tareas).then(() => {
    if (pares.length) indicadores(kpis, pares);
    if (!graficos.children.length) graficos.remove();
  });

  const titulo = document.createElement('h2');
  titulo.className = 'titulo-seccion';
  titulo.textContent = 'Módulos';
  const rejilla = document.createElement('div');
  rejilla.className = 'rejilla columnas-3';
  for (const modulo of modulos) {
    const tarjetaModulo = document.createElement('article');
    tarjetaModulo.className = 'tarjeta modulo tarjeta-modulo';
    const caja = document.createElement('span');
    caja.className = 'modulo-icono';
    caja.style.background = estilo(modulo.clave).fondo;
    caja.append(icono(estilo(modulo.clave).icono));
    const nombre = document.createElement('h3');
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
    tarjetaModulo.append(caja, nombre, lista);
    rejilla.append(tarjetaModulo);
  }
  if (!modulos.length) {
    const aviso = document.createElement('p');
    aviso.textContent = 'Su rol no tiene módulos habilitados. Solicite el acceso a RRHH.';
    rejilla.append(aviso);
  }
  contenedor.append(titulo, rejilla);
}
