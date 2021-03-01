// Oefeningen week 1


// Schrijf een functie 'multiply()'
// 2 parameters (number,number)
// output: De vermenigvuldiging van de twee getallen die als input gegeven werden.
function multiply(number1, number2) {
    return number1 * number2;
}


// Schrijf een functie 'difference()'
// 1 parameter
// output: Het verschil tussen het ingegeven getal en het getal 100.
function difference(getal) {
    return 100 - getal;
}


// Schrijf een functie 'isFifty()'
// 2 parameters
// output: Geeft TRUE terug als één van de getallen '50' is OF de som van de 2 getallen '50' is.
function isFifty(getal, getal2) {
    if(getal === 50 || getal2 === 50 || getal + getal2 === 50) {
        return true
    } 
    else {
        return false;
    }
}


// Schrijf een functie 'startsWithHello()'
// 1 parameter
// output: Als de inputstring begint met 'Hello ', return gewoon de string. Begint ze niet met 'Hello ', plak dit er dan voor.
function startsWithHello(inputstring) {
    let extra = "Hello "; 
    if(inputstring.substring(0, 6).toLowerCase() == "hello") {
        return inputstring;
    } else {
        return extra + inputstring;
    }
}


// Schrijf een functie 'removeCharacter()'
// 2 parameters (string, number)
// output: Verwijder het zoveelste karakter uit je string en print de nieuwe string (met dus 1 karakter minder)
// TIP: Kijk naar String.substring of String.slice
function removeCharacter(string, number) {
    return string.substring(0, number - 1) + string.substring(number)
}


// Schrijf een functie 'capitalizeEveryWord()'.
// 1 parameter (string)
// output: Elk woord in de inputstring start met een hoofdletter, de rest van de letters zijn een kleine letter.
// TIP: Zoek String.prototype.split() , String.charAt() , String.substring() en String.join() op
function capitalizeEveryWord(string) {
    let splitstring = string.split();
    let uitvoer = "";
    for (let i = 0; i < splitstring.length; i++) {
        uitvoer += splitstring[i].charAt(0).toUpperCase() + string.slice(1) + "\n";
    }
    return uitvoer;
}


// Schrijf een functie 'countVowels()'.
// 1 parameter (string)
// output: Het aantal klinkers dat voorkomt in de input string.
// TIP: Loop over je string en kijk voor elke letter of die overeen komt met één van de klinkers.
function countVowels(string) {
    let count = 0;
    for(let i = 0; i < string.length; i++) {
        switch(string.substring(i, i+1))
        {
            case "a": 
            case "e": 
            case "i": 
            case "o": 
            case "u": 
                count++;
                break;
        }
    }
    return count;
}


// Schrijf een functie 'maxValue()'
// 3 parameters
// output: De functie geeft het grootste getal van de 3 als resultaat
function maxValue(getal1, getal2, getal3) {
    return Math.max(getal1, getal2, getal3);
}



console.log('Output oef 1:', multiply(2, 2), multiply(4, 12));
console.log('Output oef 2:', difference(156), difference(20));
console.log('Output oef 3:', isFifty(15, 35), isFifty(70, -20), isFifty(50, 180), isFifty(10, 12));
console.log('Output oef 4:', startsWithHello('Hello there'), startsWithHello('there'));
console.log('Output oef 5(a):', removeCharacter('Voorbeeld', 1), removeCharacter('Voorbeeld', 4));
console.log('Output oef 6:', capitalizeEveryWord('elk woord zou moeten beginnen met een hoofdletter'));
console.log('Output oef 7:', `De inputstring bevat ${countVowels('oefening')} klinkers`);
console.log('Output oef 8:', `Het grootste nummer is ${maxValue(12, 5, 25)}`);

