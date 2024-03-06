import { Component, OnInit, Output } from '@angular/core';
import { AlumnoService } from '../alumno.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-alumno',
  templateUrl: './alumno.component.html',
  styleUrls: ['./alumno.component.css']
})
export class AlumnoComponent {
  
  @Output() alumnos: Observable<any> = this.alumnoService.alumnos;

  constructor(private alumnoService: AlumnoService) { }

  eliminarAlumno(i: any) {
    this.alumnoService.eliminarAlumno(i);
  }
  
}
