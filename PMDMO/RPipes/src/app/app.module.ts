import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PadreComponent } from './padre/padre.component';
import { AlternarPipe } from './alternar.pipe';
import { InsertarEspaciosPipe } from './insertar-espacios.pipe';

@NgModule({
  declarations: [
    AppComponent,
    PadreComponent,
    AlternarPipe,
    InsertarEspaciosPipe
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
