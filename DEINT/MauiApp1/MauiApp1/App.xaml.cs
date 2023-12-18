using MauiApp1.Layouts;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ControlesDePresentacionDemo();
        }
    }
}
