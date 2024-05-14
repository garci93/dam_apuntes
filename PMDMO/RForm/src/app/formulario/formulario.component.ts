import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormularioComponent implements OnInit {
  formulario!: FormGroup;

  constructor(private fb: FormBuilder) {
    this.formulario = this.fb.group({
      dni: ['', []],
      checkbox: [false, []],
      edad: ['', []]
    });
  }

  ngOnInit(): void {
    this.formulario = this.fb.group({
      dni: ['', [Validators.required, this.dniValidator]],
      checkbox: [false, Validators.requiredTrue],
      edad: ['', [Validators.required, Validators.pattern("^[0-9]*$"), Validators.min(1)]]
    });
  }

  dniValidator(control: AbstractControl) {
    const dniPattern = /^[0-9]{8}[A-Z]$/;
    return dniPattern.test(control.value) ? null : { 'invalidDNI': true };
  }

  get dni() { return this.formulario.get('dni')!; }
  get checkbox() { return this.formulario.get('checkbox')!; }
  get edad() { return this.formulario.get('edad')!; }

  onSubmit() {
    if (this.formulario.valid) {
      console.log('Formulario válido', this.formulario.value);
    } else {
      console.log('Formulario no válido');
    }
  }
}
