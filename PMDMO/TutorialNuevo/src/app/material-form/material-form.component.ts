import { Component, EventEmitter, Output } from '@angular/core';
import { Material } from '../material';

@Component({
  selector: 'app-material-form',
  templateUrl: './material-form.component.html',
  styleUrls: ['./material-form.component.css']
})
export class MaterialFormComponent {
  @Output() materialCreado = new EventEmitter<Material>();

  agregarMaterial(nombre: string, cantidad: number) {
    this.materialCreado.emit(new Material(nombre, cantidad));
    }
}
