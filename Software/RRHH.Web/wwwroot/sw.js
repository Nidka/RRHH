const CACHE = 'rrhh-teletrabajo-shell-v1';
const ARCHIVOS = ['/', '/app.css', '/app.js', '/manifest.webmanifest', '/icon.svg', '/icon-192.png', '/icon-512.png'];
self.addEventListener('install', event => event.waitUntil(caches.open(CACHE).then(cache => cache.addAll(ARCHIVOS))));
self.addEventListener('activate', event => event.waitUntil(caches.keys().then(nombres =>
  Promise.all(nombres.filter(nombre => nombre.startsWith('rrhh-teletrabajo-shell-') && nombre !== CACHE)
    .map(nombre => caches.delete(nombre))))));
self.addEventListener('fetch', event => {
  const url = new URL(event.request.url);
  if (event.request.method !== 'GET' || url.origin !== self.location.origin || !ARCHIVOS.includes(url.pathname)) return;
  event.respondWith(fetch(event.request).catch(() => caches.match(url.pathname)));
});
