using RecupMarzo.MVVM.ViewModels;

namespace RecupMarzo.MVVM.Views;

public partial class MascotaView : ContentPage
{
	public MascotaView()
	{
		InitializeComponent();
		BindingContext = new MascotaViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.DisplayAlert("Mascota adoptada", "Esta mascota ya está adoptada", "OK");
    }
}