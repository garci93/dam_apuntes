using CollectionViewDem.MVVM.ViewModel;

namespace CollectionViewDem.MVVM.View;

public partial class CollectionDemoView : ContentPage
{
	public CollectionDemoView()
	{
		InitializeComponent();
		BindingContext = new CollectionViewModel();
	}
}