// Registra el service worker para que la aplicación sea instalable.
if ('serviceWorker' in navigator) {
  window.addEventListener('load', () => {
    navigator.serviceWorker.register('/service-worker.js').catch(() => { /* sin soporte o contexto no seguro: la web funciona igual */ });
  });
}
