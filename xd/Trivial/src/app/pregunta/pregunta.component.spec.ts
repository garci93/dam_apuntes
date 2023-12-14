import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PreguntaComponent } from './pregunta.component';

describe('PreguntaComponent', () => {
  let component: PreguntaComponent;
  let fixture: ComponentFixture<PreguntaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PreguntaComponent]
    });
    fixture = TestBed.createComponent(PreguntaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
