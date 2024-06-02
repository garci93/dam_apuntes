import { TestBed } from '@angular/core/testing';

import { ServicioRecetasService } from './servicio-recetas.service';

describe('ServicioRecetasService', () => {
  let service: ServicioRecetasService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServicioRecetasService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
