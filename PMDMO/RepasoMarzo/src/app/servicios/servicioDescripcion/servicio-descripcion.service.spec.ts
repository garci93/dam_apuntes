import { TestBed } from '@angular/core/testing';

import { ServicioDescripcionService } from './servicio-descripcion.service';

describe('ServicioDescripcionService', () => {
  let service: ServicioDescripcionService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServicioDescripcionService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
