import { Injectable } from '@angular/core';
import { authGuard } from './auth.guard';

@Injectable({
  providedIn: 'root'
})
export class ServicioUsuarioService extends authGuard{
  login() {
    authGuard.isLoggedIn = true;
  }

  constructor() { }
}
