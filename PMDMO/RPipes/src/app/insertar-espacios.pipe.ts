import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'insertarEspacios'
})
export class InsertarEspaciosPipe implements PipeTransform {

  transform(texto: string, espacios: number): string {
    let result = '';
    for (let i = 0; i < texto.length; i++) {
      if (i % espacios == espacios-1) {
        result += texto[i] + ' ';
      } else {
        result += texto[i];
      }
    }
    return result;
  }

}
