import { Component } from '@angular/core';
import { ServicioUsuarioService } from '../servicio-usuario.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(public servicioUsuario: ServicioUsuarioService) { }
  login() {
    this.servicioUsuario.login();
  }
}
