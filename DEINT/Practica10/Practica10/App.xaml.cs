using Practica10.MVVM.Models;
using Practica10.MVVM.Views;
using Practica10.Repository;

namespace Practica10
{
    public partial class App : Application
    {
        public static BaseRepository<Transacciones> TransaccionesRepo { get; private set; }

        public App(BaseRepository<Transacciones> transaccionesRepo)
        {
            InitializeComponent();
            TransaccionesRepo = transaccionesRepo;
            MainPage = new NavigationPage(new GastosView());
        }
    }
}
