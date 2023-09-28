import { Component } from '@angular/core';

@Component({
  selector: 'hijo',
  templateUrl: './hijo.component.html',
  styleUrls: ['./hijo.component.css']
})
export class HijoComponent {
  @Input propiedad:string="Lo que sea 2";
}
