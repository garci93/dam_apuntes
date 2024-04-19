import { Component } from '@angular/core';
import { Servicio } from '../servicio';

@Component({
  selector: 'app-padre',
  templateUrl: './padre.component.html',
  styleUrls: ['./padre.component.css']
})
export class PadreComponent {
  constructor(private servicio: Servicio) {
  }
}
