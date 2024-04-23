import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListaTareasComponent } from './lista-tareas/lista-tareas.component';
import { TareaComponent } from './tarea/tarea.component';
import { Servicio } from './servicio';

@NgModule({
  declarations: [
    AppComponent,
    ListaTareasComponent,
    TareaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [Servicio],
  bootstrap: [AppComponent]
})
export class AppModule { }
