import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'censura'
})
export class CensuraPipe implements PipeTransform {

  transform(texto: string, palabrasCensuradas: string): string {
    let palabras = texto.split(" ");
    let arrayPalabrasCensuradas = palabrasCensuradas.split(",");
    let asteriscos = '****';
    for (var palabra of palabras){
      for (var palabrota of arrayPalabrasCensuradas) {
        if (palabra = palabrota)
        texto = texto.replace(palabra,asteriscos);
      }
    }
    return texto;
  }
}
