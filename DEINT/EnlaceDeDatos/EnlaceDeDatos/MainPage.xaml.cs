using EnlaceDeDatos.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EnlaceDeDatos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Persona persona = new Persona(){
                Nombre = "AAA",
                Telefono = "638572794",
                Direccion = "EEE",
            };
            BindingContext = persona;
        }

    }

}
