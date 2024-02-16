using ExamenFinal.MVVM.ViewModels;

namespace ExamenFinal.MVVM.Views;

public partial class Pantalla2View : ContentPage
{
	public Pantalla2View(PrincipalViewModel principalViewModel)
	{
		InitializeComponent();
		BindingContext = principalViewModel;
	}
}