import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UsuarioService } from '../servicios/servicioUsuario/usuario.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  loginForm: FormGroup;

  constructor(private router: Router, private servicioUsuario: UsuarioService){
    this.loginForm = new FormGroup({
      nombre: new FormControl('', [Validators.required, Validators.minLength(4)]),
      contrasena: new FormControl('', [Validators.required, Validators.minLength(8)])
    });
  }


  acceder(nombre: string, contrasena: string){
    if(this.servicioUsuario.comprobarUsuario(nombre, contrasena)){
      this.router.navigate(['principal']);
    }
  }

  registrarse(){
    this.router.navigate(['signup']);
  } 

}
