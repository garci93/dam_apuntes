import { CanActivateFn } from '@angular/router';
import { Router } from '@angular/router';
import { LoginService } from '../servicios/servicioLogin/login.service';
import { UsuarioService } from '../servicios/servicioUsuarios/usuario.service';
import { inject } from '@angular/core';

export const loginGuardGuard: CanActivateFn = (route, state) => {

  if(inject(LoginService).estaLogueado()){
    return true
  }
  else{
    inject(Router).navigate(['/login']);
    return false;
  }
};