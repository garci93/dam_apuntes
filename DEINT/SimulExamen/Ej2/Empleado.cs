using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Empleado
    {
        private double pagoPorHorasExtra;
        private int horasPorMes;

        public string DNI {  get; set; }
        public string Nombre {  get; set; }
        public double SueldoBase {  get; set; }
        public double PagoPorHoraExtra { get; set; }
        public int HorasExtrasMes {  get; set; }
        public int TipoIRPF {  get; set; }
        public bool Casado {  get; set; }
        public int Hijos {  get; set; }

        public Empleado() { }

        public Empleado(string dni) {
            try
            {
                if (Regex.IsMatch(dni, @"^\d{8}[A-Z]$")) DNI = dni;
            }
            catch (FormatException)
            {
                Console.WriteLine("El DNI debe tener ocho cifras y una letra mayúscula");
            }
            Nombre = "";
            SueldoBase = 0;
            PagoPorHoraExtra = 0;
            HorasExtrasMes = 0;
            TipoIRPF = 0;
            Casado = false;
            Hijos = 0;
        }

        public Empleado(string dni, string nombre, double sueldoBase, double pagoPorHorasExtra, int horasPorMes, int tipoIRPF, bool casado, int hijos) : this(dni)
        {
            try
            {
                if (Regex.IsMatch(dni, @"^\d{8}[A-Z]$")) DNI = dni;
            }
            catch (FormatException)
            {
                Console.WriteLine("El DNI debe tener ocho cifras y una letra mayúscula");
            }
            DNI = dni;
            Nombre = nombre;
            SueldoBase = sueldoBase;
            PagoPorHoraExtra = pagoPorHorasExtra;
            HorasExtrasMes = horasPorMes;
            TipoIRPF = tipoIRPF;
            Casado = casado;
            Hijos = hijos;
        }

        public double Complemento() {
                return PagoPorHoraExtra * HorasExtrasMes;
        }

        public double SueldoBruto()
        {
            return SueldoBase + Complemento();
        }

        public double Retenciones()
        {
            int PuntosMenos = Hijos;
            if (Casado) PuntosMenos += 2;
            return SueldoBruto()*(100 - TipoIRPF + PuntosMenos)/100;
        }

        public string toString()
        {
            return "Nombre: " + Nombre + "\nSueldo neto: " + (SueldoBruto() - Retenciones());
        }
    }
}
