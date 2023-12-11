import { TestBed } from '@angular/core/testing';
import { CanActivateFn } from '@angular/router';

import { pruebaGuard } from './prueba.guard';

describe('pruebaGuard', () => {
  const executeGuard: CanActivateFn = (...guardParameters) => 
      TestBed.runInInjectionContext(() => pruebaGuard(...guardParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeGuard).toBeTruthy();
  });
});
