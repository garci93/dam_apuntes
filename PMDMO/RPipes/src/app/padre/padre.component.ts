import { Component } from '@angular/core';

@Component({
  selector: 'app-padre',
  templateUrl: './padre.component.html',
  styleUrls: ['./padre.component.css']
})
export class PadreComponent {
  texto: string = '';
  espacios: number = 3;

  constructor() { }

  cambiarTexto() {
    this.texto = "texto cambiado desde el padre";
  }
}
