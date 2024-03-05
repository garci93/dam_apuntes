import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../servicios/servicioLogin/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  public error: boolean = false;
  public mensajeError: string | undefined;
  
  constructor(private router: Router, private loginService: LoginService) { }

  login(nombre: string, contrasena: string): void {
    if (nombre && contrasena) {
      if ( contrasena.length >= 8) {
        if (this.loginService.login(nombre, contrasena)) {
          this.router.navigate(['/formulario']);
        } else {
          this.error = true;
          this.mensajeError = 'Usuario o contraseña incorrectos';
        }
      } else {
        this.error = true;
        this.mensajeError = 'La contraseña debe tener al menos 8 caracteres';
      }

    } else {
      this.error = true;
      this.mensajeError = 'Debe completar todos los campos';
    }
  }

}
