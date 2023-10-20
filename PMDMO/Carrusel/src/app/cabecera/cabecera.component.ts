import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-cabecera-input',
  templateUrl: './cabecera.component.html',
  styleUrls: ['./cabecera.component.css']
})
export class CabeceraComponent {
  @Input() logoUrl!: string;
}
