import { Component } from '@angular/core';
import { Tarea } from '../tarea';
import { Servicio } from '../servicio';

@Component({
  selector: 'app-lista-tareas',
  templateUrl: './lista-tareas.component.html',
  styleUrls: ['./lista-tareas.component.css']
})
export class ListaTareasComponent {
  tareas!: Tarea[];
  constructor(public servicio: Servicio) {
  }

  ngOnInit() {
    this.servicio.getObservableTareas().subscribe(tareas => {this.tareas = tareas});
  }

  completarTarea(tarea: Tarea) {
    console.log('hola desde completarTarea en lista-tareas.component.ts');
    this.servicio.completarTarea(tarea);
  }

}
