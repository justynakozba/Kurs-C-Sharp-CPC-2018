 /*Funkcja zmieniająca kolory stopki*/
var counter = 1;
function changeColor() {

    if (document.getElementById("navigation").style.backgroundColor == "blue") {
        document.getElementById("navigation").style.backgroundColor = "red";
    }
    else if (document.getElementById("navigation").style.backgroundColor == "blue") {
        document.getElementById("navigation").style.backgroundColor = "yellow";
    }
    else {
        document.getElementById("navigation").style.backgroundColor = "cyan";
    }
    document.getElementById("navigation").innerHTML = "Licznik: " + counters;
    counter++;
}

/*Ustawienie zdarzenia cyklicznego w zależności od czasu*/
setInterval(changeColor, 1000)


ob1.addEventListener('click', calculate1());
/*Funkcja możliwiająca dodawanie, odejmowanie, mnożenie i dzielenie*/
function calculate1() {
    var num1 = parseInt(window.prompt("Podaj pierwszą liczbę", "1"), 10);
    var num2 = parseInt(window.prompt("Podaj drugą liczbę", "1"), 10);
    var c = num1 + num2;
    var d = num1 - num2;
    var e = num1 * num2;
    var f = num1 / num2;
    alert("Wynik dodawania: " + c + "\n" + "Wynik odejmowania: " + d + "\n" + "Wynik mnożenia: " + e + "\n" + "Wynik dzielenia: " + f);
}