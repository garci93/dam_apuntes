using Practica10.MVVM.Views;

namespace Practica10
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new GastosView());
        }
    }
}
