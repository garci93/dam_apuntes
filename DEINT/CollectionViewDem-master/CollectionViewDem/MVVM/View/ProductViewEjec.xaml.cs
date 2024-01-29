using CollectionViewDem.MVVM.ViewModel;

namespace CollectionViewDem.MVVM.View;

public partial class ProductViewEjec : ContentPage
{
	public ProductViewEjec()
	{
		InitializeComponent();
		BindingContext = new CollectionViewModel();

	}
}