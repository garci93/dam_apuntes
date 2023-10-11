using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAcceso
{
    internal class CuentaEmpresarial : CuentaBancaria
    {
        public CuentaEmpresarial(string _titular, double _saldo) : base(_titular, _saldo)
        {
        }

        public void RealizarTransferencia(CuentaBancaria c2, double cantidad){
            base.RealizarTransferencia(c2 , cantidad);
        }
        public void RealizarTransferencia(CuentaEmpresarial c2, double cantidad){
            base.RealizarTransferencia(c2 , cantidad);
        }
    }
}
