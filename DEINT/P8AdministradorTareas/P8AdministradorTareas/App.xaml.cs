using P8AdministradorTareas.MVVM.Views;

namespace P8AdministradorTareas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new TareaView());
        }
    }
}
