import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { FormularioComponent } from './formulario/formulario.component';
import { loginGuardGuard } from './guards/login-guard.guard';
import { PaginaDetalleComponent } from './pagina-detalle/pagina-detalle.component';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent},
  { path: 'formulario', component: FormularioComponent, canActivate: [loginGuardGuard]},
  { path: 'paginaDetalle/:nombre/:edad/:mensaje', component: PaginaDetalleComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
