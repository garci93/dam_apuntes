using MauiApp1.Controller;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ComandosDemo();
        }
    }
}
