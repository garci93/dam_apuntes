using ExamenJunio.MVVM.Models;
using ExamenJunio.MVVM.ViewModels;

namespace ExamenJunio.MVVM.Views;

public partial class VistaPrincipal : ContentPage
{
	public VistaPrincipal()
	{
		InitializeComponent();
		BindingContext = new SneakerViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		SneakerViewModel viewModel = (SneakerViewModel)BindingContext;
		viewModel.ToggleFavoriteCommand.Execute((Sneaker)((Button)sender).BindingContext);
    }
}