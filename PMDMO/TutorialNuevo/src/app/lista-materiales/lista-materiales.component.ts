import { Component } from '@angular/core';
import { Material } from '../material';

@Component({
  selector: 'app-lista-materiales',
  templateUrl: './lista-materiales.component.html',
  styleUrls: ['./lista-materiales.component.css']
})
export class ListaMaterialesComponent {
  materiales: Material[];
  constructor() {
    this.materiales = [
    new Material('Bolígrafos', 100),
    new Material('Pegatinas', 50),
    new Material('Gomas de borrar', 80),
    new Material('Lápices', 150),
    new Material('Folios', 500)];
  }
}
