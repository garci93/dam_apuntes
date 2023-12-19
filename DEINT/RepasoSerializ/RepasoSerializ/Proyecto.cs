using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RepasoSerializ
{
    public class Proyecto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime fecha {  get; set; }
        public List<Tarea> Lista { get; set; }
        public Proyecto() { }

        public Proyecto(string nombre, string descripcion, DateTime fecha, List<Tarea> lista)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            this.fecha = fecha;
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

        public void SerializarProyectoJSON()
        {

            using (FileStream stream = new FileStream(Nombre + "\\archivo.json", FileMode.Create))
            {
                JsonSerializer.Serialize(stream, this);
            }
        }

        public Proyecto DeserializarProyecto()
        {
            XmlSerializer serializer = new XmlSerializer (typeof(Proyecto));
            Proyecto p = new Proyecto();
            using (FileStream stream = new FileStream(Nombre + "\\archivo.xml", FileMode.Open))
            {
                p = (Proyecto)serializer.Deserialize(stream);
            }
            return p;
        }

        public Proyecto DeserializarProyectoJSON()
        {
            Proyecto p = new Proyecto();
            using (FileStream stream = new FileStream(Nombre + "\\archivo.json", FileMode.Open))
            {
                p = (Proyecto)JsonSerializer.Deserialize(stream,typeof(Proyecto));
            }
            return p;
        }

        public void ExportarProyecto()
        {
            if (!Directory.Exists("Proyectos Exportados"))
            {
                Directory.CreateDirectory("Proyectos Exportados");
            }
            File.Copy(Nombre + "\\archivo.xml","Proyectos Exportados\\"+Nombre+".xml");
        }
    }
}
