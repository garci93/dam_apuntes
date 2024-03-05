import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormularioComponent implements OnInit{

  formulario!: FormGroup;

  constructor(private fb: FormBuilder, private router: Router) { }

  ngOnInit(): void {
		this.formulario = this.fb.group({
			nombre: ['', Validators.required],
			edad: [null, Validators.min(16)],
      mensaje: ['', Validators.maxLength(100)]
		});
	}

  enviarDatos() { 
    this.router.navigate(['paginaDetalle', this.formulario.value.nombre, this.formulario.value.edad, this.formulario.value.mensaje]);
  }

}