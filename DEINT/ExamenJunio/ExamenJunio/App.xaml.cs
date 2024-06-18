using ExamenJunio.MVVM.Views;

namespace ExamenJunio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VistaPrincipal();
        }
    }
}
