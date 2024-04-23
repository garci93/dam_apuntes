export class Tarea {

  private titulo: string;
  private completada: boolean;
  
  constructor(titulo: string, completada: boolean) {
      this.titulo = titulo;
      this.completada = completada;
      console.log(this.titulo, this.completada);
  }

  getTitulo () {
    return this.titulo;
  }

  getCompletada () {
    return this.completada;
  }

  setTitulo (titulo: string) {
    this.titulo = titulo;
  }

  setCompletada (completada: boolean) {
    this.completada = completada;
  }

  marcarCompletada() {
    console.log("hola desde tarea.ts");
    this.completada == true ? this.completada = false : this.completada = true;
  }
}
