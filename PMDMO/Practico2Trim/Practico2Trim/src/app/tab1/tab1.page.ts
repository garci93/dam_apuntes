import { Component } from '@angular/core';
import { Producto } from '../producto';
import { GestionService } from '../gestion.service';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})

export class Tab1Page extends GestionService {
  override addCarrito(producto: Producto): void {
    super.addCarrito(producto);
  }
  constructor() {
    super();
  }
}
