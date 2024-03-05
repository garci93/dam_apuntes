import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'pasarMayusculas'
})
export class PasarMayusculasPipe implements PipeTransform {

  transform(value: any, ...args: any[]) {
    return value.toUpperCase();
  }

}
