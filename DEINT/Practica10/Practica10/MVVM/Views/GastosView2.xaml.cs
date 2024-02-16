using Practica10.MVVM.ViewModels;

namespace Practica10.MVVM.Views;

public partial class GastosView2 : ContentPage
{
    private readonly GastosViewModel _gastosViewModel;
    public GastosView2(GastosViewModel gastosViewModel)
	{
		InitializeComponent();
		BindingContext = gastosViewModel;
	}

    private void Cancelar_Clicked(object sender, EventArgs e)
    {
        if (Navigation.NavigationStack.Count > 1)
        {
            Navigation.PopAsync();
        }
    }
}