using CollectionViewDem.MVVM.ViewModel;

namespace CollectionViewDem.MVVM.View;

public partial class ProductViewOtrosFormatos : ContentPage
{
	public ProductViewOtrosFormatos()
	{
		InitializeComponent();
		BindingContext = new CollectionViewModel();
	}
}