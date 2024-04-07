import { Component } from '@angular/core';
import { Material } from '../material';
import { Service } from '../service';

@Component({
  selector: 'app-padre',
  templateUrl: './padre.component.html',
  styleUrls: ['./padre.component.css']
})
export class PadreComponent {
  constructor(private servicio: Service) {
  }
  llamarAgregarMaterial(material: Material) {
    this.servicio.agregarMaterial(material);
  }
}
