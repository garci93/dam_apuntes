import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HijoPaginaDetalleComponent } from './hijo-pagina-detalle.component';

describe('HijoPaginaDetalleComponent', () => {
  let component: HijoPaginaDetalleComponent;
  let fixture: ComponentFixture<HijoPaginaDetalleComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HijoPaginaDetalleComponent]
    });
    fixture = TestBed.createComponent(HijoPaginaDetalleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
