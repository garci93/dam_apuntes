import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PanelFiltroComponent } from './panel-filtro.component';

describe('PanelFiltroComponent', () => {
  let component: PanelFiltroComponent;
  let fixture: ComponentFixture<PanelFiltroComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PanelFiltroComponent]
    });
    fixture = TestBed.createComponent(PanelFiltroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
