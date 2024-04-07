import { Component } from '@angular/core';
import { Material } from '../material';
import { Service } from '../service';

@Component({
  selector: 'app-lista-materiales',
  templateUrl: './lista-materiales.component.html',
  styleUrls: ['./lista-materiales.component.css'],
  providers: [Service]
})
export class ListaMaterialesComponent {
  constructor(private servicio: Service) {
  }

  llamarQuitarMaterial(material: Material) {
    this.servicio.quitarMaterial(material);
  }

  get materiales(): Material[] {
    return this.servicio.getMateriales();
  }
}
