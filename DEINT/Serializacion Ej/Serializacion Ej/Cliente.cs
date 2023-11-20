namespace Serializacion_Ej
{
    internal class Cliente
    {
        public Cliente(string dni, string nombre, string direccion, int edad, int telefono, int cuenta_corriente) {
            DNI = dni;
            Nombre = nombre;
            Direccion = direccion;
            Edad = edad;
            Telefono = telefono;
            CuentaCorriente = cuenta_corriente;
        }

        string DNI {  get; set; }
        string Nombre { get; set; }
        string Direccion { get; set; }
        int Edad {  get; set; }
        int Telefono { get; set; }
        int CuentaCorriente { get; set; }

    }
}