import { BehaviorSubject, Subject } from "rxjs";
import { Tarea } from "./tarea";

export class Servicio {
    private tareaCompletadaSubject: BehaviorSubject<Tarea[]>;

    private tareaCompletada$;

    private tareas!: Tarea[];
    
    constructor() {
        this.tareas = [
            new Tarea('Tarea 1', false),
            new Tarea('Tarea 2', true),
            new Tarea('Tarea 3', false),
            new Tarea('Tarea 4', true),
            new Tarea('Tarea 5', false)
        ];
        this.tareaCompletadaSubject = new BehaviorSubject<Tarea[]>(this.tareas);
        this.tareaCompletada$ = this.tareaCompletadaSubject.asObservable();
    }

    getObservableTareas() {
        return this.tareaCompletada$;
    }
    
    completarTarea(tarea: Tarea) {
        console.log('hola desde completarTarea en servicio.ts');
        tarea.marcarCompletada();
        this.tareaCompletadaSubject.next(this.tareas);
    }
}
