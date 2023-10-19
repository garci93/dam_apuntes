import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Cabecera2Component } from './cabecera2.component';

describe('Cabecera2Component', () => {
  let component: Cabecera2Component;
  let fixture: ComponentFixture<Cabecera2Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Cabecera2Component]
    });
    fixture = TestBed.createComponent(Cabecera2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
