export class Tarea {

    titulo: string;
    completada: boolean;
    
    constructor(titulo: string, completada: boolean) {
        this.titulo = titulo;
        this.completada = completada;
        console.log(this.titulo, this.completada);
    }

  marcarCompletada() {
    console.log("hola desde tarea.ts");
    this.completada == true ? this.completada = false : this.completada = true;
  }
}
