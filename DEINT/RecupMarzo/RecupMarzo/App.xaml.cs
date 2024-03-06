using RecupMarzo.MVVM.Views;

namespace RecupMarzo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MascotaView();
        }
    }
}
