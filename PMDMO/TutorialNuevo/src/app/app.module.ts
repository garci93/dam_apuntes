import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListaMaterialesComponent } from './lista-materiales/lista-materiales.component';
import { MaterialComponent } from './material/material.component';

@NgModule({
  declarations: [
    AppComponent,
    ListaMaterialesComponent,
    MaterialComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
