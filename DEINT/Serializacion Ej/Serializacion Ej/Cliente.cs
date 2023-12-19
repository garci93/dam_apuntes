using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Serializacion_Ej
{
    [Serializable]
    public class Cliente
    {
        public Cliente(string dni, string nombre, string direccion, int edad, int telefono, long cuenta_corriente) {
            DNI = dni;
            Nombre = nombre;
            Direccion = direccion;
            Edad = edad;
            Telefono = telefono;
            CuentaCorriente = cuenta_corriente;
        }

        public Cliente()
        {

        }

        [XmlElement("Codigo")]

        public string DNI {  get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad {  get; set; }
        public int Telefono { get; set; }
        public long CuentaCorriente { get; set; }

        public void GuardarEnArchivo(string nombreArchivo)
        {
            try
            {
                // Serialización del objeto cliente
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, this);
                stream.Close();

                Console.WriteLine("Cliente guardado en el archivo: " + nombreArchivo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el cliente en el archivo: " + ex.Message);
            }
        }

    }
}