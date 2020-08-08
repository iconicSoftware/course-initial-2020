let title = document.getElementById("Suma de valores");

let num1 = 0;
let num2 = 0;

document.getElementById("num1").addEventListener('keyup',(e) => {
    num1 = e.target.value;
});

document.getElementById("num2").addEventListener('keyup',(e) => {
    num2 = e.target.value
});

function suma(a,b){
    let c = parseInt(a) + parseInt(b);
    return 'La suma es : ' + c;
}


document.getElementById('operacion').addEventListener('click',() => {
    alert(suma(num1,num2));
});