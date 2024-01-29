using CollectionViewDem.MVVM.ViewModel;

namespace CollectionViewDem.MVVM.View;

public partial class ProductDicView : ContentPage
{
	public ProductDicView()
	{
        InitializeComponent();
		BindingContext = new CollectionViewModel();
	}
}