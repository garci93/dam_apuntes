import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'alternar'
})
export class AlternarPipe implements PipeTransform {

  transform(texto: string): string {
    let result = '';
    for (let i = 0; i < texto.length; i++) {
      if (i % 2 == 0) {
        result += texto[i].toUpperCase();
      } else {
        result += texto[i].toLowerCase();
      }
    }
    return result;
  }

}
