import { Component } from '@angular/core';

@Component({
  selector: 'app-padre',
  templateUrl: './padre.component.html',
  styleUrls: ['./padre.component.css']
})
export class PadreComponent {
  texto: string = 'texto cambiado desde el padre';
  mostrar: boolean = false;
  espacios: number = 5;

  constructor() { }

  cambiarTexto() {
    this.mostrar = true;
  }
}
