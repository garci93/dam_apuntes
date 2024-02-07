using Practica10.MVVM.ViewModels;

namespace Practica10.MVVM.Views;

public partial class GastosView2 : ContentPage
{
	public GastosView2(GastosViewModel gastosViewModel)
	{
		InitializeComponent();
		BindingContext = gastosViewModel;
	}
}