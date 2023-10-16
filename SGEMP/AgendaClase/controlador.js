//asi con array es un poco "guarro"
let arrayContactos = [new Contacto('Pepe'),new Contacto('Manolo'),new Contacto('Maria')];
let listaContacto; //ul

function main() {
    //1. selecciono los elementos del dom
    //el boton añadir contactos para ponerle un manejador de eventos
    let botonFormulario = document.querySelector('#botonFormulario');
    //el ul para luego añadirle un li para cada contacto
    listaContacto = document.getElementById('listado');

    //2. addeventlistener
    botonFormulario.addEventListener('click', addContacto);
}

function addContacto () {
    //1 Voy a recoger los valores que el usuario ha introducido en los inputs
    let nombre = document.querySelector('#nombre').value;

    //TODO resto de campos
    //2 Voy a añadir un nuevo objeto Contacto al array
    arrayContactos.push(new Contacto(nombre));
}

window.addEventListener('load', main);