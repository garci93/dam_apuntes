import { inject } from '@angular/core';
import { Router, CanActivateFn } from '@angular/router';
import { UsuarioService } from './usuario.service';

export const AuthGuard: CanActivateFn = (route, state) => {
  const servicio = inject(UsuarioService);
  const router = inject(Router);
  if (servicio.loguear()) {
    return true;
  } else {
    router.navigate(['']);
    return false;
  }
};
