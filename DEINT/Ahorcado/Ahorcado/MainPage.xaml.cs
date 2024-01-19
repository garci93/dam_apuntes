using Ahorcado.MVVM.ViewModels;

namespace Ahorcado
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new AlfabetoViewModel();
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }
    }

}
