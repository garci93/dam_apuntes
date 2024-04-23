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

  constructor() {}

  completarTarea() {
      console.log("hola desde tarea.component.ts");
      // Emite el evento tareaCompletada con los datos de la tarea
      this.tareaCompletada.emit(this.data);
  }
}
