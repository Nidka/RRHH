// Service worker del piloto web de RRHH.
// Guarda solo la estructura de la aplicación (HTML, CSS, JS e íconos) para que se abra y se pueda instalar.
// Nunca guarda respuestas de /api ni de /salud: los datos de personal se piden siempre al servidor.
const VERSION = 'rrhh-web-v3';
// Las pantallas de cada módulo (js/modulos/) se guardan al abrirlas por primera vez.
const ESTRUCTURA = ['/', '/app.css', '/pwa.js', '/icon.svg', '/icon-192.png', '/manifest.webmanifest',
  '/js/app.js', '/js/componentes/api.js', '/js/componentes/mensajes.js', '/js/componentes/tabla.js',
  '/js/componentes/fechas.js', '/js/componentes/formulario.js', '/js/componentes/navegacion.js',
  '/js/componentes/selector-empleado.js', '/js/componentes/ui.js', '/js/componentes/graficos.js',
  '/js/componentes/nombres.js', '/js/componentes/paleta.js', '/js/componentes/tema.js'];

self.addEventListener('install', evento => {
  evento.waitUntil(caches.open(VERSION).then(cache => cache.addAll(ESTRUCTURA)).then(() => self.skipWaiting()));
});

self.addEventListener('activate', evento => {
  evento.waitUntil(
    caches.keys()
      .then(claves => Promise.all(claves.filter(clave => clave !== VERSION).map(clave => caches.delete(clave))))
      .then(() => self.clients.claim()));
});

self.addEventListener('fetch', evento => {
  const solicitud = evento.request;
  const url = new URL(solicitud.url);
  if (solicitud.method !== 'GET' || url.origin !== self.location.origin) return;
  if (url.pathname.startsWith('/api') || url.pathname.startsWith('/salud')) return;
  // Red primero: si el servidor responde se usa y se refresca la copia; sin red se usa la copia guardada.
  evento.respondWith(
    fetch(solicitud)
      .then(respuesta => {
        if (respuesta.ok) {
          const copia = respuesta.clone();
          caches.open(VERSION).then(cache => cache.put(solicitud, copia));
        }
        return respuesta;
      })
      .catch(() => caches.match(solicitud).then(guardada => guardada || caches.match('/'))));
});
