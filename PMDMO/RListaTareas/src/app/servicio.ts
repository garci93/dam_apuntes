import { Tarea } from "./tarea";

export class Servicio {

    tareas: Tarea[] = [
        new Tarea('Tarea 1', false),
        new Tarea('Tarea 2', true),
        new Tarea('Tarea 3', false),
        new Tarea('Tarea 4', true),
        new Tarea('Tarea 5', false)
    ];
    
    constructor() { }
    
    getTareas() {
        return this.tareas;
    }
    
    completarTarea(indice: number) {
        this.tareas[indice].completada = true;
    }
}
