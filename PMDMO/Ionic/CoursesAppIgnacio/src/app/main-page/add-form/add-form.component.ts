import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'add-form',
  templateUrl: './add-form.component.html',
  styleUrls: ['./add-form.component.scss'],
})
export class AddFormComponent  implements OnInit {
  @Output() addCourseEvent = new EventEmitter<Object>();

  alertButtons = ['Aceptar'];
  isAlertOpen: boolean = false;
  form! : FormGroup;

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.clearForm();
  }

  clearForm(): void {
    this.form = this.formBuilder.group({
      title: ['', [Validators.required]],
      points: ['', [Validators.required]]
    });
  }

  onSubmit(): void {
    if (this.form.valid) {
      this.addCourseEvent.emit({title : this.form.value.title, points : this.form.value.points});

      this.clearForm();
    } else {
      this.setAlertOpen(true);
    }
  }

  setAlertOpen(isOpen: boolean) {
    this.isAlertOpen = isOpen;
  }
}
