// Recorrer un arreglo de 6 números y sumar solo los números pares. Mostrar resultado.

// division /
// mod %

// 4 / 2 = 2
// 4 % 2 = 0

// = asignacion
// == comparacion debil
// === comparacion fuerte

let arreglo = [1,2,4,5,6,1];

function sumaArreglo(numeros) {
    let resultado = 0;
    for (let index = 0; index < numeros.length ; index++) {
        if(numeros[index] % 2 === 0) { // es par
            resultado = resultado + numeros[index];
            // resultado += arreglo[index];
            // index++ | index = index + 1 | index += 1
        }
    }
    return resultado;
}

let res = sumaArreglo(arreglo);

console.log('suma pares arreglo 1 : ', res);






