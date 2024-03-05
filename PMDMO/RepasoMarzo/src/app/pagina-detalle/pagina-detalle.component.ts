import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ServicioDescripcionService } from '../servicios/servicioDescripcion/servicio-descripcion.service';

@Component({
  selector: 'app-pagina-detalle',
  templateUrl: './pagina-detalle.component.html',
  styleUrls: ['./pagina-detalle.component.css']
})
export class PaginaDetalleComponent implements OnInit {
    public nombre!: string
    public edad!: number
    public mensaje!: string

    public dinero: number = 0

    public descripcion!: any

  constructor(private activateRoute: ActivatedRoute, private descripcionService: ServicioDescripcionService) { }

  ngOnInit(): void {
    this.activateRoute.params.subscribe(params => {
      this.nombre = params['nombre'];
      this.edad = params['edad'];
      this.mensaje = params['mensaje'];
    });

    this.descripcionService.getDescripcion$().subscribe(descripcion => {
      this.descripcion = descripcion;
    });
  }

  recogerDinero(dinero: number) {
    this.dinero = dinero;
    // alert(`El dinero que tiene ${this.nombre} es ${dinero}`);
  }
}
