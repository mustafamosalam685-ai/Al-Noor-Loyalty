const CACHE_NAME = "alnoor-loyalty-v4";
const APP_SHELL = [
  "./",
  "./index.html",
  "./login.html",
  "./register.html",
  "./card.html",
  "./rewards.html",
  "./locations.html",
  "./menu.html",
  "./alnoor.html",
  "./staff.html",
  "./manifest.json",
  "./icon-192.png",
  "./icon-512.png"
];

self.addEventListener("install", event => {
  event.waitUntil((async () => {
    const cache = await caches.open(CACHE_NAME);
    await Promise.all(
      APP_SHELL.map(async url => {
        try { await cache.add(url); } catch (_) {}
      })
    );
    await self.skipWaiting();
  })());
});

self.addEventListener("activate", event => {
  event.waitUntil((async () => {
    const keys = await caches.keys();
    await Promise.all(
      keys.filter(k => k !== CACHE_NAME).map(k => caches.delete(k))
    );
    await self.clients.claim();
  })());
});

self.addEventListener("fetch", event => {
  if (event.request.method !== "GET") return;

  const url = new URL(event.request.url);
  if (url.origin !== self.location.origin) return;

  event.respondWith(
    fetch(event.request)
      .then(response => {
        if (response && response.ok) {
          const copy = response.clone();
          caches.open(CACHE_NAME).then(cache => cache.put(event.request, copy)).catch(()=>{});
        }
        return response;
      })
      .catch(() => caches.match(event.request).then(cached => {
        return cached || new Response("Offline", {
          status: 503,
          headers: {"Content-Type": "text/plain"}
        });
      }))
  );
});
