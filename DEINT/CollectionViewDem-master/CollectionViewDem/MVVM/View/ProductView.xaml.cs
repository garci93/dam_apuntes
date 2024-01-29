using CollectionViewDem.MVVM.ViewModel;

namespace CollectionViewDem.MVVM.View;

public partial class ProductView : ContentPage
{
	public ProductView()
	{
		InitializeComponent();
		BindingContext = new CollectionViewModel();
	}
}