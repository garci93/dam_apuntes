import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title:string = 'Proyecto2';
  // title = 'my-first-project';

  pulsarBoton() {
    this.title='Me has pulsado.'
  }
}
