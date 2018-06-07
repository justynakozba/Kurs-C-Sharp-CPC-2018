document.getElementById("text-information").style.backgroundColor = "deeppink";
var counter = 1;
function changeFooterTextAndColor() {
    document.getElementById("footer-block").style.backgroundColor = "yellow";
    document.getElementById("footer-block").innerHTML = "Licznik: " + counters;
    counter++;
}

function changeBanner() {
    document.getElementById("banner-element").style.width = "300px";
    alert("zadziałało!");
}

/*Ustawienie zdarzenia cyklicznego w zależności od czasu*/
setInterval(changeFooterTextAndColor, 1000)





