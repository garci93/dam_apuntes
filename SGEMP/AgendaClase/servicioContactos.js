//Esta clase la instanciará una sola vez (Singleton) en el controlador
class ServicioContactos {
    //Propiedades. Encapsulo el array para protegerlo
    arrayContactos = [new Contacto('Pepe'),new Contacto('Manolo'),new Contacto('Maria')];

    //Leer Contactos
    obtenerContactos(){
        //Convierto el array de objetos contacto en un array de objetos literales
        let objetoLiteral = {};
        let cadenas = ['nombre','edad'];
        let arrayObjetosLiterales = [];

        for (let i = 0; i < this.arrayContactos.length; i++) {
            for (propiedad in arrayContactos[i]){
                objetoLiteral.cadenas[i] = propiedad
            }
            arrayObjetosLiterales.push(objetoLiteral);
        }

        return arrayObjetosLiterales;
    }

    //Añadir contactos
    addContacto(datos){
        arrayContactos.push(new Contacto(datos.nombre));
    }

    borrarContacto(id){
        //Borraré el contacto del arrayoriginal.
    }
}