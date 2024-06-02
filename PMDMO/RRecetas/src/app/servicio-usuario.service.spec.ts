import { TestBed } from '@angular/core/testing';

import { ServicioUsuarioService } from './servicio-usuario.service';

describe('ServicioUsuarioService', () => {
  let service: ServicioUsuarioService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServicioUsuarioService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
