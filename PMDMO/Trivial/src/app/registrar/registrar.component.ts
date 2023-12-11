import { Component } from '@angular/core';
import { UsuarioService } from '../usuario.service';
import { Router } from '@angular/router';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthGuard } from '../auth.guard';

@Component({
  selector: 'app-registrar',
  templateUrl: './registrar.component.html',
  styleUrls: ['./registrar.component.css']
})
export class RegistrarComponent {
  registrarForm !: FormGroup;
  minlength: number = 6;
  maxlength: number = 20;
  constructor(private servicio: UsuarioService, private router: Router) {
    this.registrarForm = new FormGroup({
      usuario: new FormControl('', [Validators.required, Validators.minLength(this.minlength), Validators.maxLength(this.maxlength)]),
      password: new FormControl('', [Validators.required, Validators.minLength(this.minlength), Validators.maxLength(this.maxlength)]),
    });
  }


  registrar(usuario:string, password:string) {
    this.servicio.anadirUsuario(usuario, password);
    this.router.navigate(['']);
  }

}
