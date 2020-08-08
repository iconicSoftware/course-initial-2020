console.log("Hola mundo HTML - JS");

let num1 = 0;
let num2 = 0;

// recibe el valor de un input
document.getElementById("num1").addEventListener('keyup',function(e){
    num1 = e.target.value;
});

document.getElementById("num2").addEventListener('keyup',function(e){
    num2 = e.target.value;
});

function sumarNumeros(a,b) {
    let c = parseInt(a) + parseInt(b);
    return "El resultado de la suma es :" +  c;
}

// escucha evento click en un boton
document.getElementById("sumar").addEventListener('click',function(){
    alert(sumarNumeros(num1,num2));
});

let nombre = "";

document.getElementById("text1").addEventListener('keyup',function(e){
    nombre = e.target.value;
});

// escucha evento click en un boton
document.getElementById("saludar").addEventListener('click',function(){
    alert("Bienvenido al curso " + nombre);
});


console.log("Finalizando");
