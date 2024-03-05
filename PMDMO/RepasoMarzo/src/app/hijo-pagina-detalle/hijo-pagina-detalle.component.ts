import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ServicioDescripcionService } from '../servicios/servicioDescripcion/servicio-descripcion.service';

@Component({
  selector: 'app-hijo-pagina-detalle',
  templateUrl: './hijo-pagina-detalle.component.html',
  styleUrls: ['./hijo-pagina-detalle.component.css']
})
export class HijoPaginaDetalleComponent {
  @Input() nombre!: string
  @Output() dinero: any = new EventEmitter<any>();

  constructor(private descripcionService: ServicioDescripcionService) { }

  mostrarDinero() {
    this.dinero.emit(25);
  }

  enviarDescripcion(descripcion: string) {
    this.descripcionService.setDescripcion(descripcion);
  }
}
