import { Injectable } from '@angular/core';
import { Usuario } from 'src/app/clases/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  private usuarios!: Usuario[];

  private autenticado: boolean;

  constructor() {
    this.autenticado = false;

    this.usuarios = [      
      new Usuario("admin123", "admin123"), 
      new Usuario("usuario", "usuario")
    ]
  }

  addUsuario(nombre: string, contrasena: string){
    this.usuarios.push(new Usuario(nombre, contrasena));
  }

  comprobarUsuario(nombre: string, contrasena: string){
    this.autenticado = false;
    this.usuarios.forEach(usuario => {
      if(usuario.getNombre() === nombre && usuario.getContrasena() == contrasena){
        this.autenticado = true;
      }
    });
    return this.autenticado 
  }

  existeUsuario(){
    return this.autenticado;
  }

}
