import { Injectable } from '@angular/core';
import { Usuario } from './usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  private usuarios: Usuario[] = [];

  private estaLogueado: boolean = false;

  constructor() { }

  anadirUsuario(usuario: string, password: string) {
    this.usuarios.push(new Usuario(usuario,password));
  }

  comprobarUsuario(usuario: string, password: string) {
    for (let i = 0; i < this.usuarios.length; i++) {
      if (this.usuarios[i].nombre() == usuario && this.usuarios[i].password() == password) {
        this.estaLogueado = true;
        return true;
      }
    }
    this.estaLogueado = false;
    return false;
  }

  loguear() {
    return this.estaLogueado;
  }
    
}
