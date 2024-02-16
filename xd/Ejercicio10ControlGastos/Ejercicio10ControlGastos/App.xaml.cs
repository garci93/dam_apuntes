using Ejercicio10ControlGastos.MVVM.Model;
using Ejercicio10ControlGastos.MVVM.View;
using Ejercicio10ControlGastos.Repository;

namespace Ejercicio10ControlGastos
{
    public partial class App : Application
    {
        public static BaseRepository<Cliente> ClienteRepo { get; private set; }
        public static BaseRepository<Transaccion> TransaccionRepo { get; private set; }

        public App(BaseRepository<Cliente> clienteRepo, BaseRepository<Transaccion> transaccionRepo)
        {
            InitializeComponent();

            ClienteRepo = clienteRepo;
            TransaccionRepo = transaccionRepo;

            MainPage = new NavigationPage(new ControlGastosView());

        }
    }
}
