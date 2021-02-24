let zin = "Ik wil een lasagne van de pxl-catering";

let indexnul = zin.charAt(0);
let indexdrie = zin.charAt(3);
let laatstK = zin.lastIndexOf("k");
let laatstE = zin.lastIndexOf("e");
let length = zin.length;

let uitvoer = indexnul + " " + indexdrie + " " + laatstE + " " + laatstK + " " + length;
console.log(document.getElementById('zin').innerHTML = uitvoer);


document.getElementById('zin').innerHTML = uitvoer.toUpperCase();
