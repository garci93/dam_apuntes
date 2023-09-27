//Definir los datos que necesitamos. Variables, arrays, clases.
let simbolos = ['+', '-', '/','*', 'sqrt'];

//Definición de funciones Funciones
function suma(sumando1,sumando2){
    return sumando1 + sumando2;
}

function resta(minuendo,sustraendo){
    return minuendo - sustraendo;
}
function multiplicacion(factor1,factor2){
    return factor1 * factor2;
}

function division(dividendo,divisor){
    return dividendo / divisor;
}

function raiz(numero){
    return Math.sqrt(numero);
}


//Empiezo pidiendo la entrada de datos
let simbolo = prompt("Introduzca '+' si desea sumar.\nIntroduzca '-' si desea restar.\nIntroduzca '/' si desea dividir.\nIntroduzca '*' si desea multiplicar.\nIntroduzca 'sqrt' si desea hacer la raiz cuadrada.")
let operando1= float( prompt('Introduzca el primer operando'));
if(simbolo!='sqrt'){
    let operando2= float( prompt('Introduzca el segundo operando'));
}

//Algoritmo y Salida de datos
if(simbolo == '+'){
    console.log(`El resultado de la suma es: ${suma(operando1,operando2)}`);
}else if(simbolo == simbolos[1]){
    console.log(`El resultado de la resta es: ${resta(operando1,operando2)}`);
}else if(simbolo == simbolos[2]){
    console.log(`El resultado de la division es: ${division(operando1,operando2)}`);
}else if(simbolo == simbolos[3]){
    console.log(`El resultado de la multiplicacion es: ${multiplicacion(operando1,operando2)}`);
}else if(simbolo == simbolos[4]){
    console.log(`El resultado de la raiz cuadrada es: ${raiz(operando1)}`);
}





