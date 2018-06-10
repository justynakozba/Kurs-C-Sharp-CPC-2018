window.addEventListener('load', startClock);
window.addEventListener('load', modyfikacja);
/* Funkcja odpowiedzialna wystartowanie zegara*/
function startClock() {
    updateClock();
    setInterval("updateClock()", 1000);
}

/* Funkcja odpowiedzialna zakualizowanie zegara*/
function updateClock() {
    node = document.getElementById("clock");
    now = new Date();
    node.innerHTML = now.toLocaleString();
}

/* Funkcja odpowiedzialna modyfikowanie czasu*/
function modyfikacja() {
    node = document.getElementById("modyf");
    node.innerHTML = document.lastModified.toLocaleString();
}
