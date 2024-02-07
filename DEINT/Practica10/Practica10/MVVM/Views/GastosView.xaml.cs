using Practica10.MVVM.ViewModels;

namespace Practica10.MVVM.Views;

public partial class GastosView : ContentPage
{
	GastosViewModel gastosViewModel;
	public GastosView()
	{
		InitializeComponent();
		gastosViewModel = new GastosViewModel();
		BindingContext = gastosViewModel;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		GastosView2 gastosView2 = new GastosView2(gastosViewModel);
		await Application.Current.MainPage.Navigation.PushAsync(gastosView2);
    }
}