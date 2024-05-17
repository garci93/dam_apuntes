import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { GestorComponent } from './gestor/gestor.component';
import { PanelFiltroComponent } from './panel-filtro/panel-filtro.component';
import { ListaProyectosComponent } from './lista-proyectos/lista-proyectos.component';
import { ProyectoComponent } from './proyecto/proyecto.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    GestorComponent,
    PanelFiltroComponent,
    ListaProyectosComponent,
    ProyectoComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
