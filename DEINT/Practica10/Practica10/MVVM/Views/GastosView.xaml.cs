using Practica10.MVVM.ViewModels;

namespace Practica10.MVVM.Views;

public partial class GastosView : ContentPage
{
	public GastosView()
	{
		InitializeComponent();
		BindingContext = new GastosViewModel();
	}
}