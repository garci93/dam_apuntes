export class Usuario {
    private _nombre: string;
    private _contrasena: string;

    constructor(nombre: string, contrasena: string) {
        this._nombre = nombre;
        this._contrasena = contrasena;
    }

    get nombre(): string {
        return this._nombre;
    }

    set nombre(nombre: string) {
        this._nombre = nombre;
    }

    get contrasena(): string {
        return this._contrasena;
    }

    set contrasena(contrasena: string) {
        this._contrasena = contrasena;
    }
}
