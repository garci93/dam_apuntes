import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Tarea } from '../tarea';
import { Servicio } from '../servicio';
import { find } from 'rxjs';

@Component({
  selector: 'app-tarea',
  templateUrl: './tarea.component.html',
  styleUrls: ['./tarea.component.css']
})
export class TareaComponent {
  @Input('tarea') data!: Tarea;
  @Output() tareaCompletada: EventEmitter<Tarea> = new EventEmitter<Tarea>();

  constructor(public servicio: Servicio) {}

  completarTarea() {
    const tareaCompletar = this.servicio.getTareas().find(t => t.titulo === this.data.titulo);
    if (tareaCompletar) {
      console.log("hola desde tarea.component.ts");
      // Emite el evento tareaCompletada con el estado de la tarea
      this.tareaCompletada.emit(new Tarea(tareaCompletar.titulo, tareaCompletar.completada));
    }
  }
}
