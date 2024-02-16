using ExamenFinal.MVVM.ViewModels;
using PropertyChanged;
using System.Windows.Input;

namespace ExamenFinal.MVVM.Views;

public partial class Pantalla4View : ContentPage
{

    public Pantalla4View(PrincipalViewModel principalViewModel)
    {
        InitializeComponent();
        BindingContext = principalViewModel;
    }

    private async void llamar_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Mensaje", "Contacto agregado", "OK");
    }
}