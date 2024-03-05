import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { FormularioComponent } from './formulario/formulario.component';
import { ReactiveFormsModule } from '@angular/forms';
import { PaginaDetalleComponent } from './pagina-detalle/pagina-detalle.component';
import { PasarMayusculasPipe } from './pasar-mayusculas.pipe';
import { HijoPaginaDetalleComponent } from './hijo-pagina-detalle/hijo-pagina-detalle.component';
import { DirectivaColorDirective } from './directivas/directiva-color.directive';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    FormularioComponent,
    PaginaDetalleComponent,
    PasarMayusculasPipe,
    HijoPaginaDetalleComponent,
    DirectivaColorDirective
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
