
/*Funkcja zmieniająca kolory stopki*/
var counter = 1;
function changeFooterTextAndColor() {

    
    if (document.getElementById("footer-block").style.backgroundColor == "cyan") {
        document.getElementById("footer-block").style.backgroundColor = "blue";
    }
    else if (document.getElementById("footer-block").style.backgroundColor == "blue") {
        document.getElementById("footer-block").style.backgroundColor = "green";
    }
    else
    {
        document.getElementById("footer-block").style.backgroundColor = "cyan";
    }
    document.getElementById("footer-block").innerHTML = "Licznik: " + counters;
    counter++;
}

/*Ustawienie zdarzenia cyklicznego w zależności od czasu*/
setInterval(changeFooterTextAndColor, 1000)
