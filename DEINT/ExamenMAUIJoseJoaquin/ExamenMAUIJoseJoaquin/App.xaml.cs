using ExamenMAUIJoseJoaquin.MVVM.Views;

namespace ExamenMAUIJoseJoaquin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PedidoView();
        }
    }
}
