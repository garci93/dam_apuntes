import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthGuard } from '../auth.guard'; // Add the import statement for AuthGuard
import { UsuarioService } from '../usuario.service';
import { Form, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  loginForm !: FormGroup;
  minlength: number = 6;
  maxlength: number = 20;
  constructor(private servicio: UsuarioService, private router: Router, private authGuard: AuthGuard) {
    this.loginForm = new FormGroup({
      usuario: new FormControl('', [Validators.required, Validators.minLength(this.minlength), Validators.maxLength(this.maxlength)]),
      password: new FormControl('', [Validators.required, Validators.minLength(this.minlength), Validators.maxLength(this.maxlength)]),
    });
  }

  login(usuario:string, password:string) {
    if (this.servicio.comprobarUsuario(usuario, password)){
      this.router.navigate(['principal']);
    }
  }

  registrar() {
    this.router.navigate(['registrar']);
  }
  
}


