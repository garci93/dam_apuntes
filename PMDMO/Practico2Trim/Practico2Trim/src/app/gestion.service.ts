import { Injectable } from '@angular/core';
import { Producto } from './producto';

@Injectable({
  providedIn: 'root'
})
export class GestionService {
  carrito: Producto[] = [];
  productos: Producto[];
  productoDebug: Producto = new Producto(3, 'Prueba', 11.11, 0);
  
  constructor() {
    this.productos = [
      new Producto(1, 'Llave inglesa', 20.55, 0),
      new Producto(5, 'Martillo', 39.99, 0)
    ];
  }
  
  addCarrito(producto: Producto) {
    this.carrito.push(producto);
  }

  modifCantidad(producto: Producto,op: string) {
    if (op == 'sumar') {
      producto.cantidad++;
    } else {
      if (op == 'restar' && producto.cantidad > 0) {
        producto.cantidad--;
      }
    }
  }
}
