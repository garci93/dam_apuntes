import { Component, Input } from '@angular/core';
import { Material } from '../material';

@Component({
  selector: 'app-material',
  templateUrl: './material.component.html',
  styleUrls: ['./material.component.css']
})
export class MaterialComponent {
  @Input('material') data!: Material;  // recibe la propiedad material del padre, y la asigna a la propiedad data, que es de tipo Material

  constructor() {
  }
}
