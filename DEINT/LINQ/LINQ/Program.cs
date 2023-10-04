using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Class1
    {
        static void Main(String[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] numeros2 = Enumerable.Range(1, 10).ToArray();

            var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

            var numerosPares2 = (from n in numeros
                                 where n % 2 == 0
                                 select n).ToList();

            var numerosImpares = numeros2.Where( n => n % 2 == 1).ToList();

            var numerosImparesMayoresQue10 = numeros.Where( n => n % 2 == 1 && n > 10).ToList();

            // var consulta = fromTabla.Where(condicion);

            // .ToList() es para asegurarnos de que sea una lista

            //fecha.addMonths(#)            -> añadir # meses a la fecha actual, puede ser negativo y así restarlos

            //consulta.First();             -> devuelve el primer elemento de la consulta, si no hay, da excepción
            //consulta.FirstOrDefault();    -> devuelve el primer elemento de la consulta o si no hay, el que viene por defecto

            var paises = new List<string>();

            var primerPais = paises.First();
            var primerPais2 = paises.FirstOrDefault();

            //al introducir condiciones dentro de un first (+or default), si no se cumple, el first da excepción, el or default da null y tal (valores por defecto)

            //algo is null                  -> comprobar ¿algo es nulo?
            //se pueden encadenar las operaciones o meterlas una en otra

            int[] numeros3 = { 1, 6, 4, 8, 10 };

            var numerosOrdenados = numeros.OrderBy(x => x).ToList();       //devuelve los numeros ordenados, x => x es para ordenarlos con una funcion lambda

            //var persona1 = new { Nombre = "Pepa", Edad = 12};

            //var nombres = personas.Select(personas=>personas.Nombre).ToList(); ->  devuelve solo los nombres de las personas

            // .Count()     -> xd
            // .LongCount() -> si son muchos y no cabe en un entero

            // .Sum(alias => alias.atributoNumerico);
            // .Min(), .Max(), .Average()
            // .MinBy() y .MaxBy() ordenan por una secuencia especificada por el programador
        }
    }
}
