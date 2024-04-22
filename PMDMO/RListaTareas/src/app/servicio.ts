import { BehaviorSubject, Subject } from "rxjs";
import { Tarea } from "./tarea";

export class Servicio {
    private tareaCompletadaSubject: BehaviorSubject<Tarea> = new BehaviorSubject<Tarea>(new Tarea('', false));

    tareaCompletada$ = this.tareaCompletadaSubject.asObservable();

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
    
    completarTarea(tarea: Tarea) {
        console.log('hola desde completarTarea en servicio.ts');
        tarea.marcarCompletada();           //aquí intento que sea la clase Tarea la que la marque como completada
        this.tareaCompletadaSubject.next(tarea);
    }
}
