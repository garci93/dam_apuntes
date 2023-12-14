export class Usuario {

    private nombre: string;
    private contrasena: string;

    constructor(nombre: string, contrasena: string){
        this.nombre = nombre;
        this.contrasena = contrasena;
    }

    getNombre(){
        return this.nombre;
    }

    getContrasena(){
        return this.contrasena;
    }

    setNombre(nombre: string){
        this.nombre = nombre;
    }

    setContrasena(contrasena: string){
        this.contrasena = contrasena;
    }


}
