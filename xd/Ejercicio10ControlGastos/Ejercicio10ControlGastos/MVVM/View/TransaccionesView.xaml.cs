using Ejercicio10ControlGastos.MVVM.ViewModel;

namespace Ejercicio10ControlGastos.MVVM.View;

public partial class TransaccionesView : ContentPage
{
	public TransaccionesView()
	{
		InitializeComponent();

        BindingContext = new TransaccionesViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ControlGastosView());
    }
}