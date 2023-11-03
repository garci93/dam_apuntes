using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.DLL
{
    class CicloDLL
    {
        Conexion conexion;
        public CicloDLL()
        {
            conexion = new Conexion();
        }
        public bool Agregar(string nombreCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos("Insert into Ciclo(NombreCiclo) values ('" + nombreCiclo + "')");
        }

        internal bool Modificar(string id, string nombreCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos("Update Ciclo Set NombreCiclo = " + nombreCiclo + "Where ID = " + id);
        }
    }
}
