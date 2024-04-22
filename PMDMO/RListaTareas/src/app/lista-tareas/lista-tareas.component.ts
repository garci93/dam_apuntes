import { Component } from '@angular/core';
import { Tarea } from '../tarea';
import { Servicio } from '../servicio';

@Component({
  selector: 'app-lista-tareas',
  templateUrl: './lista-tareas.component.html',
  styleUrls: ['./lista-tareas.component.css']
})
export class ListaTareasComponent {
  constructor(public servicio: Servicio) {
  }

  get tareas(): Tarea[] {     //habría que cambiar este get para que sea Observable<Tarea[]>?
    return this.servicio.getTareas();
  }

  completarTarea(tarea: Tarea) {
    console.log('hola desde completarTarea en lista-tareas.component.ts');
    this.servicio.completarTarea(tarea);
  }

  ngOnInit() {
    this.servicio.tareaCompletada$.subscribe(tarea => this.tareas.find(t => t.titulo === tarea.titulo)?.marcarCompletada());
  }
}
