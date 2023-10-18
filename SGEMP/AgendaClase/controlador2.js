//Versión buena. Sigue MVC

//INSTANCIO EL SERVICIO
let servicio = new ServicioContactos();
let arrayContactos = servicio.obtenerContactos();

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

    //3-Muestro en el <ul> los datos de los contactos el array que he obtenido del servicio.
    //TO-DO: Tengo que crear una cadena de texto con todos los contactos en forma de <li>
    listarContactos();
    
    

    listaContacto.innerHTML = textoLista;
}

function listarContactos(){
    let textoLista="";
    //Un For donde creo el <li> con el contenido oportuno.
    //crear button para cada elemento
    //Al botón le pondré un manejador de eventos borrarContacto()
    listaContacto.innerHTML = textoLista;
}

function addContacto () {
    //1 Voy a recoger los valores que el usuario ha introducido en los inputs
    let nombre = document.querySelector('#nombre').value;

    //TODO resto de campos
    //2 LLAMO AL METODO CORRESPONDIENTE DE LA API DEL SERVICIO
    //Los datos se suelen serializar en un objeto JSON
    let datos = {nombreContacto: nombre}
    servicio.addContacto(datos);
}

function borrarContacto(e){
    //coge id contacto y llama a servicio
    //e.target del objeto evento me dice sobre que objeto se origino el evento
    servicio.borrarContacto(id);
    //elimino de array copia de objetos literales ese objeto y vuelvo a listar
}

window.addEventListener('load', main);