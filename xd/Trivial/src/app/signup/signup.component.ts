import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UsuarioService } from '../servicios/servicioUsuario/usuario.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent {

  signupForm: FormGroup;

  constructor(private router: Router, private servicioUsuario: UsuarioService){
    this.signupForm = new FormGroup({
      nombre: new FormControl('', [Validators.required, Validators.minLength(4)]),
      contrasena: new FormControl('', [Validators.required, Validators.minLength(8)])
    })
  }

  registro(nombre: string, contrasena:string){
    if(this.signupForm.valid){
      this.servicioUsuario.addUsuario(nombre, contrasena);
      this.router.navigate(['']);
    }
    
  }

  cancelar(){
    this.router.navigate(['']);
  }

}
