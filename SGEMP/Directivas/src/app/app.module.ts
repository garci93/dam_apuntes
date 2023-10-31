import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EnlaceComponent } from './enlace/enlace.component';
import { PasarEnlaceDirective } from './pasar-enlace.directive';

@NgModule({
  declarations: [
    AppComponent,
    EnlaceComponent,
    PasarEnlaceDirective
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
