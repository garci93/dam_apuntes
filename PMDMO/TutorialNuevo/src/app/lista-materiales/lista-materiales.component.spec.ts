import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaMaterialesComponent } from './lista-materiales.component';

describe('ListaMaterialesComponent', () => {
  let component: ListaMaterialesComponent;
  let fixture: ComponentFixture<ListaMaterialesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ListaMaterialesComponent]
    });
    fixture = TestBed.createComponent(ListaMaterialesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
