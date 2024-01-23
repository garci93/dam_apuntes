using CalculadoraDemo.MVVM.Views;

namespace CalculadoraDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculadoraView();
        }
    }
}
