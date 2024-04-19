import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Tarea } from '../tarea';
import { Servicio } from '../servicio';

@Component({
  selector: 'app-tarea',
  templateUrl: './tarea.component.html',
  styleUrls: ['./tarea.component.css']
})
export class TareaComponent {
  @Input('tarea') data!: Tarea;
  @Output() tareaCompletada: EventEmitter<number> = new EventEmitter<number>();

  constructor(private servicio: Servicio) {}

  completarTarea() {
    console.log(this.data.indice);
    this.servicio.completarTarea(this.data.indice);
    this.tareaCompletada.emit(this.data.indice);
  }
}
