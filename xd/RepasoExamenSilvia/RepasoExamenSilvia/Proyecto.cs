using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RepasoExamenSilvia
{
    public class Proyecto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public List<Tarea> Lista { get; set; }

        public Proyecto() { }
        public Proyecto(string nombre, string descripcion, DateTime fecha, List<Tarea> lista)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Fecha = fecha;
            Lista = lista;
            CrearDirectorio();
        }
        public void CrearDirectorio()
        {
            Directory.CreateDirectory(Nombre);
        }
        public void SerializarProyecto()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Proyecto));

            using (FileStream stream = new FileStream(Nombre+"\\archivo.xml",FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }
        }
        public Proyecto DeserializarProyecto()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Proyecto));
            Proyecto proyecto;

            using (FileStream stream = new FileStream(Nombre + "\\archivo.xml", FileMode.Open))
            {
                proyecto = (Proyecto)serializer.Deserialize(stream);
            }
            return proyecto;
        }

        public void SerializarProyectoJSON()
        {
            using (var stream = new FileStream(Nombre+"\\archivo.json", FileMode.Create))
            {
                JsonSerializer.Serialize(stream, this);
            }
           
        }

        public Proyecto DeserializarProyectoJSON()
        {
            Proyecto p;
            using (var stream = new FileStream(Nombre + "\\archivo.json", FileMode.Open))
            {
                p  = (Proyecto)JsonSerializer.Deserialize(stream,typeof(Proyecto));
            }
            return p;
        }

        public void ExportarProyecto()
        {
            if (!Directory.Exists("Proyectos Exportados"))
            {
                Directory.CreateDirectory("Proyectos Exportados");
            }
            else
            {
                Console.WriteLine("El Directorio ya esta creado");
            }

            File.Copy(Nombre + "\\archivo.xml", "Proyectos Exportados\\"+Nombre+".xml");
            
        }
    }
}
