export class Usuario {
    private _nombre: string;
    private _password: string;

    constructor(nombre: string, password: string) {
        this._nombre = nombre;
        this._password = password;
    }

    nombre(): string {
        return this._nombre;
    }

    password(): string {     
        return this._password;
    }
}
