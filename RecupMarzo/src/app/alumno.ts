export class Alumno {
    nombre: string;
    curso: string;
    media: number;

    constructor(nombre: string, curso: string, media: number) {
        this.nombre = nombre;
        this.curso = curso;
        this.media = media;
    }

    getNombre() {
        return this.nombre;
    }

    getCurso() {
        return this.curso;
    }

    getMedia() {
        return this.media;
    }

    setNombre(nombre: string) {
        this.nombre = nombre;
    }

    setCurso(curso: string) {
        this.curso = curso;
    }

    setMedia(media: number) {
        this.media = media;
    }
}
