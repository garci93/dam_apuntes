import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Cabecera3Component } from './cabecera3.component';

describe('Cabecera3Component', () => {
  let component: Cabecera3Component;
  let fixture: ComponentFixture<Cabecera3Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Cabecera3Component]
    });
    fixture = TestBed.createComponent(Cabecera3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
