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
            /*
                var persona1 = new { Nombre = "Pepa", Edad = 12};

                var nombres = personas.Select(personas=>personas.Nombre).ToList(); ->  devuelve solo los nombres de las personas

                 .Count()     -> xd
                 .LongCount() -> si son muchos y no cabe en un entero

                 .Sum(alias => alias.atributoNumerico);
                 .Min(), .Max(), .Average()
                 .MinBy() y .MaxBy() ordenan por una secuencia especificada por el programador

                .All(condicion) => devuelve si la cond se cumple en todos o no

                .Contains(valor) => devuelve si alguno de los registros contiene valor

                .Take(num)        => toma los num primeros registros
                .TakeLast(num)    => toma los num ultimos registros
                .Skip(num)        => quita los num primeros registros y devuelve los demas
                .SkipLast(num)    => quita los num ultimos registros y devuelve los demas
                .TakeWhile(cond)  => va tomando hasta que la cond deje de cumplirse, ahi termina (aunque vuelva a cumplirse otra vez mas adelante)
                .SkipWhile(cond)  => va saltando hasta que la cond deje de cumplirse, el resto lo toma (aunque vuelva a cumplirse otra vez mas adelante)

                .GroupBy(prop(s)) => agrupar segun un atributo
                    .GroupBy(ob => new {c.prop1, c.prop2, ...}) => agrupar segun varios atributos

                .Distinct()       => eliminar repetidos
                .DistinctBy(atr)  => eliminar repetidos segun un atributo

                .Chunk(num)       => dividir en num trozos
            */
        }
    }
}
