using CollectionViewDem.MVVM.View;

namespace CollectionViewDem
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProductViewOtrosFormatos();
        }
    }
}
