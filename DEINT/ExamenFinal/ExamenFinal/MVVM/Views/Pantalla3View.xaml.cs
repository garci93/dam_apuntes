using ExamenFinal.MVVM.ViewModels;

namespace ExamenFinal.MVVM.Views;

public partial class Pantalla3View : ContentPage
{
    public Pantalla3View(PrincipalViewModel principalViewModel)
    {
        InitializeComponent();
        BindingContext = principalViewModel;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pantalla1View());
    }
}