using Ej2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static void Main(string[] args){
    Console.WriteLine("¿Cuántos empleados desea introducir?");
    int nuevosEmp = int.Parse(Console.ReadLine());
    Empleado[] empleados = new Empleado[nuevosEmp];
    
    for (int i = 0; i < nuevosEmp; i++)
    {
        try
        {
            Console.WriteLine("Introduzca DNI");
            string dni = Console.ReadLine();
            Console.WriteLine("Introduzca nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduzca sueldo base");
            double sueldoBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el pago por horas extra");
            double pagoPorHorasExtra = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca las horas extra mensuales");
            int horasPorMes = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el % de IRPF");
            int tipoIRPF = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca si el empleado está casado (true/false)");
            bool casado = bool.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el número de hijos");
            int hijos = int.Parse(Console.ReadLine());
            empleados[i] = new Empleado(dni,nombre,sueldoBase,pagoPorHorasExtra,horasPorMes,tipoIRPF,casado,hijos);
        }
        catch (Exception)
        {
            throw new Exception("Todos los datos deben estar introducidos correctamente");
        }
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