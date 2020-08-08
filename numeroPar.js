// verificar si un numero es par
// resto %
// div /
// 4 / 2 = 2
// 4 % 2 = 0

function parImpar(num) {
    if(num%2 !== 0) { // es par
        console.log("El numero ", num, " es IMPAR");
    }else{
        console.log("El numero ", num, " es PAR");
    }
}

let numero = 10;

parImpar(numero);
