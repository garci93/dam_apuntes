//EJERCICIO: Cuando el usuario pulsa un botón se muestra una tabla con los datos de 3 coches.
//MODELO DE LA APLICACIÓN: Son los datos y el código que los manipula.
let coche1 = {
    matricula: "8888AAA",
    marca: "Audi",
    modelo: "A3",
    fechaCompra: new Date('December 25, 1995'),
    color: "Negro",
}

let coche2 = {
    matricula: "7777AAA",
    marca: "Renault",
    modelo: "Megane",
    fechaCompra: new Date('December 25, 2000'),
    color: "Gris",
}

let coche3 = {
    matricula: "5555AAA",
    marca: "VW",
    modelo: "Golf",
    fechaCompra: new Date('December 25, 2020'),
    color: "Rojo",
}

let coche4 = {
    matricula: "6666AAA",
    marca: "Nissan",
    modelo: "Qashqai",
    fechaCompra: new Date('October 13, 2013'),
    color: "Azul",
}

let coches = [coche1,coche2,coche3,coche4];

//Vale para cualquier dimensión.
const FILAS = 4;
const COLUMNAS = 5;

function main(){
    //Cojo el botón y añado el manejador para el evento click
    let boton = document.querySelector('#boton');
    boton.addEventListener('click', pulsaBoton);
}



//El manejador del evento click sobre el botón.
function pulsaBoton(){
    // //Seleccionamos el nodo div.
    let padre = document.querySelector('#padre');
    // //1ª Versión: usando la propiedad innerHTML del nodo padre (div)
     // //Defino un string para ir concatenando el código HTML de mi tabla.
    // let tablaHTML ="<table>";
    // //Vamos a usar dos bucles anidados para ir creando las etiquetas <tr> y <td>
    // //En todo momento usamos Strings que vamos concatenando para formar todo el HTML.
    // for(let i=0;i<FILAS;i++){//Se ocupa de los <tr>
    //     tablaHTML += '<tr>';
    //     for(let j=0;j<COLUMNAS;j++){//Se ocupa de los <td> y de los textos.
    //         tablaHTML += '<td>Hola</td>';
    //     }
    //     tablaHTML +='</tr>';
    // } 

    // tablaHTML += '</table>';

    // //Para visualizarlo, lo asigno al innerHTML del padre (<div>)
    // padre.innerHTML = tablaHTML;

    //2º Versión: manipulación del DOM. Con el RETO ya integrado.
    //Vamos a usar ahora los métodos createElement(), createTextNode() y appendChild()
    //para ir creando los objetos en memoria y uniéndolos entre sí.

    //Primero creo el objeto table
    let tablaDOM = document.createElement('table');

    //De nuevo usamos un bucle anidado.
    for(let i=0; i<FILAS; i++){ //Para cada fila, creo un objeto tr y lo uno a su padre (table) 
        let fila = document.createElement('tr');
        tablaDOM.appendChild(fila); //Me acuerdo de unirlo a su padre
        for(let j=0; j<COLUMNAS; j++){ //Para cada celda creo un nodo td y su nodo de texto.
            let celda = document.createElement('td');
            fila.appendChild(celda);
            //Para el texto de la celda debo diferenciar en qué columa estoy (j)
            let texto;
            switch(j){
                case 0://Mapeo: 0->Matrícula
                texto = document.createTextNode(coches[i].matricula);
                break;
                case 1://Mapeo: 1->Marca
                texto = document.createTextNode(coches[i].marca);
                break;
                case 2://Mapeo: 2->Modelo
                texto = document.createTextNode(coches[i].modelo);
                break;
                case 3://Mapeo: 3->Fecha de Compra
                texto = document.createTextNode(coches[i].fechaCompra);
                break;
                case 4://Mapeo: 3->Color
                texto = document.createTextNode(coches[i].color);
                break;
            }
            celda.appendChild(texto);
        } 
    }
    //Al final añadiremos los nodos creados al DOM con el método appendChild sobre el padre (etiqueta <div>).
    padre.appendChild(tablaDOM);
}

//Reto: Ahora en la celdas, en lugar del mismo texto van a a 
//mostrase los datos de un array de coches que tendremos en memoria.
//Debéis crear un array de objetos literales y cada objeto tendrá las
//Siguientes propiedades: matricula, marca, modelo y fecha de compra.
//Basta con 3 coches de ejemplo.

//Esperamos que la página se cargue completamente para empezar el script.
window.addEventListener('load', main);



