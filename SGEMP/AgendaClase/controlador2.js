//Versión buena. Sigue MVC

//INSTANCIO EL SERVICIO
let servicio = new ServicioContactos();

//Variables
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
    //2 LLAMO AL METODO CORRESPONDIENTE DE LA API DEL SERVICIO
    servicio.addContacto(nombre);
}

window.addEventListener('load', main);