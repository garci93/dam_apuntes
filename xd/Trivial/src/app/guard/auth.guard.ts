import { Injectable, inject } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, CanActivateFn, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { UsuarioService } from '../servicios/servicioUsuario/usuario.service';

export const authGuard: CanActivateFn = (route, state) => {

  if(inject(UsuarioService).existeUsuario()){
    return true;
  }
  else{
    inject(Router).navigate(['']);
    return false;
  }


};


@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate{
  
  constructor(private servicioUsuario: UsuarioService, private router: Router){}

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean|UrlTree>|Promise<boolean|UrlTree>|boolean|UrlTree {

    if(!this.servicioUsuario.existeUsuario()){
      this.router.navigate(['']);
      return false
    }
    return true;
  }

}
