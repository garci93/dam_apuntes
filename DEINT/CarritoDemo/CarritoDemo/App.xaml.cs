using CarritoDemo.MVVM.Views;

namespace CarritoDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CarritoView();
        }
    }
}
