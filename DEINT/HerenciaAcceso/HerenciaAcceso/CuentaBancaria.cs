using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAcceso
{
    internal class CuentaBancaria
    {
        public string Titular {  get; set; }
        public double Saldo { get; set; }

        public CuentaBancaria(string _titular, double _saldo)
        {
            Titular = _titular;
            Saldo = _saldo;
        }

        public string MostrarSaldo ()
        {
            return "El saldo de la cuenta es de " + Saldo + " euros";
        }

        public void Depositar(double cantidad)
        {
            Saldo += cantidad;
        }

        public void Retirar(double cantidad)
        {
            Saldo -= cantidad;
        }

        protected virtual void RealizarTransferencia (CuentaBancaria c2, double cantidad) {
            c2.Depositar(cantidad);
            this.Retirar(cantidad);
        }
    }
}
