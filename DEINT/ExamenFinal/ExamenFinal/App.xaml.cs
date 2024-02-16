using ExamenFinal.MVVM.Models;
using ExamenFinal.MVVM.ViewModels;
using ExamenFinal.MVVM.Views;
using ExamenFinal.Repository;

namespace ExamenFinal
{
    public partial class App : Application
    {
        public static BaseRepository<Contacto> ContactoRepo { get; private set; }

        public App()
        {
            InitializeComponent();
            ContactoRepo = new BaseRepository<Contacto>();

            MainPage = new NavigationPage(new Pantalla1View());
            BindingContext = new PrincipalViewModel();
        }

    }
}
