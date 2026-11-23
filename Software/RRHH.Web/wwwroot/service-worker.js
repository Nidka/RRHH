// Service worker del piloto web de RRHH.
// Guarda solo la estructura de la aplicación (HTML, CSS, JS e íconos) para que se abra y se pueda instalar.
// Nunca guarda respuestas de /api ni de /salud: los datos de personal se piden siempre al servidor.
const VERSION = 'rrhh-web-v1';
const ESTRUCTURA = ['/', '/app.css', '/app.js', '/pwa.js', '/icon.svg', '/icon-192.png', '/manifest.webmanifest'];

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
