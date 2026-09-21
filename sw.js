const CACHE_NAME = "alnoor-loyalty-android-v2";
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
  event.waitUntil(
    caches.open(CACHE_NAME).then(async cache => {
      for (const url of APP_SHELL) {
        try { await cache.add(url); } catch (_) {}
      }
      await self.skipWaiting();
    })
  );
});

self.addEventListener("activate", event => {
  event.waitUntil(
    caches.keys()
      .then(keys => Promise.all(
        keys.filter(key => key !== CACHE_NAME).map(key => caches.delete(key))
      ))
      .then(() => self.clients.claim())
  );
});

self.addEventListener("fetch", event => {
  if (event.request.method !== "GET") return;

  event.respondWith(
    fetch(event.request)
      .then(response => {
        const copy = response.clone();
        caches.open(CACHE_NAME).then(cache => cache.put(event.request, copy));
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
