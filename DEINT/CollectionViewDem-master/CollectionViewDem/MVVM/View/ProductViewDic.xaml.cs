using CollectionViewDem.MVVM.ViewModel;

namespace CollectionViewDem.MVVM.View;

public partial class ProductViewDic : ContentPage
{
	public ProductViewDic()
	{
		InitializeComponent();
		BindingContext = new CollectionViewModel();
	}
}