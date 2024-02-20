import { Component } from '@angular/core';
import { Producto } from '../producto';
import { Tab1Page } from '../tab1/tab1.page';
import { GestionService } from '../gestion.service';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page extends GestionService {
  constructor() {
    super();
  }
}