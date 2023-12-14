import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-pregunta',
  templateUrl: './pregunta.component.html',
  styleUrls: ['./pregunta.component.css']
})
export class PreguntaComponent {

  @Input() pregunta!: any;
  @Input() respuestas!: any[];
  @Input() juegoCompletado!: boolean;
  @Output() respuestaSeleccionada = new EventEmitter<string>();

  comprobarRespuesta(respuesta: string): void {
    this.respuestaSeleccionada.emit(respuesta);
  }

}
