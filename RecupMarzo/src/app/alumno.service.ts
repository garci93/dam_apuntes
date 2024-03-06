import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AlumnoService {
  alumnos = [
    {nombre: 'Juan', curso: 'Angular', media: 8},
    {nombre: 'Ana', curso: 'Angular', media: 7},
    {nombre: 'Luis', curso: 'Angular', media: 6},
    {nombre: 'Maria', curso: 'Angular', media: 5},
    {nombre: 'Pablo', curso: 'Angular', media: 4}
  ];

  constructor() { }

  eliminarAlumno(i: number) {
    this.alumnos.splice(i, 1);
  }
}
