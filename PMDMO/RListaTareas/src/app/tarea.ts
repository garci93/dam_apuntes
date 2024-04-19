export class Tarea {
    static total = 0;

    indice: number;
    titulo: string;
    completada: boolean;
    
    constructor(titulo: string, completada: boolean) {
        this.indice = Tarea.total;
        this.titulo = titulo;
        this.completada = completada;
        console.log(this.indice, this.titulo, this.completada);
        Tarea.total++;
    }
}
