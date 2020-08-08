function porValor(numero1,numero2){ // funcion con retorno void
    let aux = numero1;
    numero1 = numero2;
    numero1 = aux;
}

let num1 = 10;
let num2 = 20;

porValor(num1,num2);

console.log(num1,num2);