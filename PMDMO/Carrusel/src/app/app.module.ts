import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CabeceraComponent } from './cabecera/cabecera.component';
import { Cabecera2Component } from './cabecera2/cabecera2.component';
import { Cabecera3Component } from './cabecera3/cabecera3.component';

@NgModule({
  declarations: [
    AppComponent,
    CabeceraComponent,
    Cabecera2Component,
    Cabecera3Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
