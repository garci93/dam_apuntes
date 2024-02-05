using BDDemo2.MVVM.ViewModel;

namespace BDDemo2.MVVM.View;

public partial class CustomerView : ContentPage
{
	public CustomerView()
	{
		InitializeComponent();
		BindingContext = new CustomerViewModel(); 
	}
}