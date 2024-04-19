import { Component } from '@angular/core';
import { Tarea } from '../tarea';
import { Servicio } from '../servicio';

@Component({
  selector: 'app-lista-tareas',
  templateUrl: './lista-tareas.component.html',
  styleUrls: ['./lista-tareas.component.css']
})
export class ListaTareasComponent {
  constructor(private servicio: Servicio) {
  }

  get tareas(): Tarea[] {
    return this.servicio.getTareas();
  }

  tareaCompletada(indice: number) {
    this.servicio.completarTarea(indice);
  }
}
