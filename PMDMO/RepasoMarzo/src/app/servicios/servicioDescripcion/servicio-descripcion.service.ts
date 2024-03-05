import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServicioDescripcionService {

  private descripcion$: BehaviorSubject<any> = new BehaviorSubject('');

  constructor() { }

  getDescripcion$() : Observable<any> {
    return this.descripcion$.asObservable();
  }

  setDescripcion(descripcion: any) {
    this.descripcion$.next(descripcion);
  }
}
