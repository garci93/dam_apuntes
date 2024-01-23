using IMCDemo.MVVM.ViewModels;

namespace IMCDemo.MVVM.Views;

public partial class IMCView : ContentPage
{
	public IMCView()
	{
		InitializeComponent();
		BindingContext = new IMCViewModel();
	}
}