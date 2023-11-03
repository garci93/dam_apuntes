using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.Model
{
    class Estudiante
    {
        public int ID { get; set; }
        public string NombreEstudiante { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Ciclo { get; set; }
        public string Email { get; set; }
        public byte[] FotoEstudiante { get; set; }
    }
}
