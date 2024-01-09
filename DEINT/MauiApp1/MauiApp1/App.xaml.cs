using MauiApp1.Controller;
using MauiApp1.Layouts;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPageDemo();
        }
    }
}
