using IMCDemo.MVVM.Views;

namespace IMCDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new IMCView();
        }
    }
}
