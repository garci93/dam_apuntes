import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title:string = 'Proyecto2';

  array:any[];

  constructor(){
    this.array=[{firstName:'Pepe'},{firstName:'Paco'},{firstName:'Manolo'}];
  }

  pulsarBoton() {
    this.title='Me has pulsado.'
  }
}
