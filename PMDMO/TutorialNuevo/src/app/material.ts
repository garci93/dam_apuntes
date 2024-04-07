export class Material {
    private nombre: string;
    private cantidad: number;

    constructor(nombre: string, cantidad: number){
        this.nombre = nombre;
        this.cantidad = cantidad;
    }

    getNombre(): string {
        return this.nombre;
    }

    getCantidad(): number {
        return this.cantidad;
    }
}
