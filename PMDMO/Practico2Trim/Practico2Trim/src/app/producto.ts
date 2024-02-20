export class Producto extends Object {
    'id': number;
    'nombre': string;
    'precio': number;
    'cantidad': number;

    constructor(id: number, nombre: string, precio: number, cantidad: number) {
        super();
        this.id = id;
        this.nombre = nombre;
        this.precio = precio;
        this.cantidad = cantidad;
    }

    public getId(): number {
        return this.id;
    }

    public getNombre(): string {
        return this.nombre;
    }

    public getPrecio(): number {
        return this.precio;
    }

    public getCantidad(): number {
        return this.cantidad;
    }

}
