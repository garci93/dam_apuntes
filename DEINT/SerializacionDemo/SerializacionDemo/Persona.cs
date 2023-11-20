using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionDemo
{
    public class Persona
    {
        [XmlElement("Codigo")]
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public Persona()
        { }

       
        public Persona(string dNI, string nombre, string apellidos)
        {
           
            DNI = dNI;
            Nombre = nombre;
          
            Apellidos = apellidos;
        }

    }
}
