import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListaMaterialesComponent } from './lista-materiales/lista-materiales.component';
import { MaterialComponent } from './material/material.component';
import { MaterialFormComponent } from './material-form/material-form.component';
import { PadreComponent } from './padre/padre.component';
import { Service } from './service';

@NgModule({
  declarations: [
    AppComponent,
    ListaMaterialesComponent,
    MaterialComponent,
    MaterialFormComponent,
    PadreComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [Service],
  bootstrap: [AppComponent]
})
export class AppModule { }
