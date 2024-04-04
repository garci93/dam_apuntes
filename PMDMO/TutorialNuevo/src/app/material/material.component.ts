import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Material } from '../material';

@Component({
  selector: 'app-material',
  templateUrl: './material.component.html',
  styleUrls: ['./material.component.css']
})
export class MaterialComponent {
  @Input('material') data!: Material;  // recibe la propiedad material del padre, y la asigna a la propiedad data, que es de tipo Material.el ! es para que no de error de inicialización
  @Output() materialBorrado = new EventEmitter<Material>();
  constructor() {
  }
  quitarMaterial(nombre: string, cantidad: number) {
    this.materialBorrado.emit(new Material(nombre, cantidad));
    }
}
