// Recorrer un arreglo con la estatura en cm de 10 personas y determinar cuál es el 
// más alto. Mostrar el resultado.

let estatura = [120,140,110,180,130,190];
let masAlto = 0;

for (let index = 0; index < estatura.length; index++) {
    if(masAlto < estatura[index]) {
        masAlto = estatura[index];
    }
}

console.log('La persona mas alta mide :', masAlto, ' cm.')



