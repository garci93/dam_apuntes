import { Injectable } from '@angular/core';
import { UsuarioService } from '../servicioUsuarios/usuario.service';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private usuarioLogueado : boolean = false;

  constructor(private usuarioService: UsuarioService) { }

  login(nombre: string, contrasena: string): boolean {
    let usuario: any = this.usuarioService.obtenerUsuario(nombre, contrasena);
    if (usuario) {
      if (usuario.nombre === nombre && usuario.contrasena === contrasena) {
        this.usuarioLogueado = true;
        return true;
      }
    }
    this.usuarioLogueado = false;
    return false;
  }

  estaLogueado(): boolean {
    return this.usuarioLogueado;
  }
}
