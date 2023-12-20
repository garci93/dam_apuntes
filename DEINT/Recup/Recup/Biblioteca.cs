using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Recup
{
    public class Biblioteca
    {
        static Biblioteca biblioteca = new Biblioteca();
        public List<Libro> Libros = new List<Libro>();

        public void SerializarLibros()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Biblioteca));

            using (FileStream stream = new FileStream("libros.xml", FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }
        }

        public Biblioteca DeserializarLibros()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Biblioteca));
            Biblioteca b = new Biblioteca();
            
            try
            {
                using (FileStream stream = new FileStream("libros.xml", FileMode.Open))
                {
                    b = (Biblioteca)serializer.Deserialize(stream);
                }
            } catch (FileNotFoundException)
            {
                Console.WriteLine("Archivo no encontrado");
            }
            return b;
        }

        public static Biblioteca GetInstance()
        {
            return biblioteca;
        }
    }
}
