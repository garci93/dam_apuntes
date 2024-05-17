import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaProyectosComponent } from './lista-proyectos.component';

describe('ListaProyectosComponent', () => {
  let component: ListaProyectosComponent;
  let fixture: ComponentFixture<ListaProyectosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ListaProyectosComponent]
    });
    fixture = TestBed.createComponent(ListaProyectosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
