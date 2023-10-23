using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej2
{
    public class Ej2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos empleados desea introducir?");
            int nuevosEmp = int.Parse(Console.ReadLine());
            Empleado[] empleados = new Empleado[nuevosEmp];

            for (int i = 0; i < nuevosEmp; i++)
            {
                Console.WriteLine("Introduzca DNI");
                string dni = Console.ReadLine();
                try
                {
                    if (!Regex.IsMatch(dni, @"^\d{8}[A-Z]$")) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("El DNI debe tener ocho cifras y una letra mayúscula");
                }

                Console.WriteLine("Introduzca nombre");
                string nombre = Console.ReadLine();
                try
                {
                    if (!Regex.IsMatch(nombre, @"^(\w\s)+\w$")) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("El nombre no debe contener números ni símbolos");
                }

                Console.WriteLine("Introduzca el sueldo base");
                double sueldoBase = double.Parse(Console.ReadLine());
                try
                {
                    if (!Regex.IsMatch(sueldoBase.ToString(), @"^[^\-]\d+(\.\d+)?$")) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("El sueldo debe ser un número no negativo");
                }

                Console.WriteLine("Introduzca el pago por horas extra");
                double pagoPorHorasExtra = double.Parse(Console.ReadLine());
                try
                {
                    if (!Regex.IsMatch(pagoPorHorasExtra.ToString(), @"^[^\-]\d+(\.\d+)?$")) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("El sueldo debe ser un número no negativo");
                }

                Console.WriteLine("Introduzca las horas extra mensuales");
                int horasPorMes = int.Parse(Console.ReadLine());
                try
                {
                    if (!Regex.IsMatch(horasPorMes.ToString(), @"^[^\-]\d+$")) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("El sueldo debe ser un número entero no negativo");
                }

                Console.WriteLine("Introduzca el % de IRPF");
                int tipoIRPF = int.Parse(Console.ReadLine());
                try
                {
                    if (!Regex.IsMatch(tipoIRPF.ToString(), @"^[^\-]\d+$")) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("El porcentaje de IRPF debe ser un número entero no negativo");
                }

                Console.WriteLine("Introduzca si el empleado está casado (true/false)");
                bool casado = bool.Parse(Console.ReadLine());
                try
                {
                    if (!(casado.ToString().Equals("true") || (casado.ToString().Equals("false")) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ser true o false");
                }

                Console.WriteLine("Introduzca el número de hijos");
                int hijos = int.Parse(Console.ReadLine());
                try
                {
                    if (!Regex.IsMatch(hijos.ToString(), @"^[^\-]\d+$")) throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("El número de hijos debe ser un número entero no negativo");
                }

                empleados[i] = new Empleado(dni, nombre, sueldoBase, pagoPorHorasExtra, horasPorMes, tipoIRPF, casado, hijos);
            }
        }

        static string MayorSueldo(Empleado[] empleados)
        {
            return empleados.MaxBy(e => e.SueldoBruto() - e.Retenciones()).ToString();
        }
        static string MenorSueldo(Empleado[] empleados)
        {
            return empleados.MinBy(e => e.SueldoBruto() - e.Retenciones()).ToString();
        }
        static Empleado[] ConHijos(Empleado[] empleados)
        {
            return empleados.Where(e => e.Hijos > 0).ToArray();
        }
        static Empleado[] OrdenadosPorSalario(Empleado[] empleados)
        {
            return empleados.OrderBy(e => e.SueldoBruto() - e.Retenciones()).ToArray();
        }
    }
}