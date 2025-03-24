var cena = [100, 50, 75, 75, 85, 90,1000];
console.log(cena);
cena.pop();
console.log(cena);

var gInfo = document.getElementById("gInfo");
var mInfo = document.getElementById("mInfo");
var nInfo = document.getElementById("nInfo");
var lInfo = document.getElementById("lInfo");
var jInfo = document.getElementById("jInfo");
var vInfo = document.getElementById("vInfo");

function prikazi(x){
    var proizvodi = ["negro", "mentol", "narandza", "limun", "jagoda", "visnja","medeno-srce"];
    var ispis = "";
    switch(x){
        case "g":
            ispis = `<p>${cena[0]}din</p>
                    <p> 100g ${proizvodi[0]} bombona`;
            gInfo.style.backgroundColor = "darkred";
            gInfo.innerHTML = ispis;
            break;
        case "m":
            ispis = `<p>${cena[1]}din</p>
                    <p> 100g ${proizvodi[1]} bombona`;
            mInfo.style.backgroundColor = "darkred";
            mInfo.innerHTML = ispis;
            break;
        case "n":
            ispis = `<p>${cena[2]}din</p>
                    <p> 100g ${proizvodi[2]} bombona`;
            nInfo.innerHTML = ispis;
            nInfo.style.backgroundColor = "darkred";
            break;
        case "l":
            ispis = `<p>${cena[3]}din</p>
                    <p> 100g ${proizvodi[3]} bombona`;
            lInfo.innerHTML = ispis;
            lInfo.style.backgroundColor = "darkred";
            break;
        case "j":
            ispis = `<p>${cena[4]}din</p>
                    <p> 100g ${proizvodi[4]} bombona`;
            jInfo.innerHTML = ispis;
            jInfo.style.backgroundColor = "darkred";
            break;
        case "v":
            ispis = `<p>${cena[5]}din</p>
                    <p> 100g ${proizvodi[5]} bombona`;
            vInfo.innerHTML = ispis;
            vInfo.style.backgroundColor = "darkred";
            break;
    }
}
function skloni(x){
    var ispis = "";
    switch(x){
        case "g":
            gInfo.innerHTML = ispis;
            break;
        case "m":
            mInfo.innerHTML = ispis;
            break;
        case "n":
            nInfo.innerHTML = ispis;
            break;
        case "l":
            lInfo.innerHTML = ispis;
            break;
        case "j":
            jInfo.innerHTML = ispis;
            break;
        case "v":
            vInfo.innerHTML = ispis;
            break;
    }
}

function proracun(){
    var ime = prompt("Unesite vase ime:");
    var i = 0;
    var akcija = "Super akcija, izaberite preko 10 proizvoda i dobite 50% popusta na njih!";
    alert(akcija.toUpperCase());
    var negro = 0;
    var mentol = 0;
    var narandza = 0;
    var limun = 0;
    var jagoda = 0;
    var visnja = 0;
    while(i<10){
        var broj = Number(prompt("Unesite koliko kesa negro bombona zelite:"));
        negro += broj;
        i += broj;

        var broj = Number(prompt("Unesite koliko kesa mentol bombona zelite:"));
        mentol += broj;
        i += broj;

        var broj = Number(prompt("Unesite koliko kesa bombona od narandze zelite:"));
        narandza += broj;
        i += broj;

        var broj = Number(prompt("Unesite koliko kesa bombona od limuna zelite:"));
        limun += broj;
        i += broj;

        var broj = Number(prompt("Unesite koliko kesa bombona od jagode zelite:"));
        jagoda += broj;
        i += broj;

        var broj = Number(prompt("Unesite koliko kesa bombona od visnje zelite:"));
        visnja += broj;
        i += broj;
    }
    var ukupna = 100*negro + 50*mentol + 75*narandza + 75*limun + 85*jagoda + 90*visnja;
    alert(`Kupili ste: ${negro} negro bombona sa cenom ${100*negro}din.
            ${mentol} mentol bombona sa cenom ${50*mentol}din.
            ${narandza} bombona od narandze sa cenom ${75*narandza}din.
            ${limun} bombona od limuna sa cenom ${75*limun}din.
            ${jagoda} bombona od jagode sa cenom ${85*jagoda}din.
            ${visnja} bombona od visnje sa cenom ${90*visnja}din.
            
            ${ime} vasa ukupna cena bi bila: ${ukupna}din.
            A vasa cena sa popustom je: ${ukupna / 2}din.`);
}