﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal static class ExtensionesString
    {
        //CLASES EXTENDIDAS
        //Se puede extender una clase y añadirle métodos nuevos (no es heredar, es extender)
        //en vez del argumento "clase arg", dices "this clase? arg". Ejemplo:
        internal static int ContarPalabras(this string s, int valorPorDefecto)
        {
            if (string.IsNullOrWhiteSpace(s)) 
            {
                return valorPorDefecto;
            }

            var separadores = new string[] { " ", Environment.NewLine };
            var palabras = s.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            return palabras.Length;
        }

        //CLASES PARCIALES: Se definen entre varios archivos

        //internal partial class Calculadora();

        //Si en vez de get; set; usas get; init; sólo puedes hacer set para inicializar, después ya no
        //Esto se llama una propiedad inmutable
        //Si pones ? después del tipo o nombre, es que puede tomar nulo.    int[]? numeros     numeros?.length
        //OPERADOR PARA PERDONAR EL NULO ! Es para poder usar nulo donde podría dar fallo, usar con responsabilidad

        //HERENCIA

        //en vez de extends se usa :, por ejemplo      internal class Camion : Vehiculo

        //aparte de abstract (obligatorio sobreescribir) tenemos también virtual (opcional sobreescribir). se sobreescriben luego con override
        //hay que poner alguno de estos para poder sobreescribir, al contrario que en java que con poner override ya te lo hacia

        //clase sellada (sealed), no se puede derivar

        //interface: las clases derivadas tendrán que implementar todos los métodos
    }
}
