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

        string DNI {  get; set; }
        string Nombre { get; set; }
        string Direccion { get; set; }
        int Edad {  get; set; }
        int Telefono { get; set; }
        long CuentaCorriente { get; set; }

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