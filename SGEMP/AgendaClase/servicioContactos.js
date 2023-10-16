//Esta ckase ka instanciará una sola vez (Singleton)
class ServicioContactos {
    //Propiedades. Encapsulo el array para protegerlo
    arrayContactos = [new Contacto('Pepe'),new Contacto('Manolo'),new Contacto('Maria')];

    addContacto(nombre){
        arrayContactos.push(new Contacto(nombre));
    }
}