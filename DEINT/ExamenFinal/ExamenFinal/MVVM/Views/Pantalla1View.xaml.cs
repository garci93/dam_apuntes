using ExamenFinal.MVVM.ViewModels;

namespace ExamenFinal.MVVM.Views;

public partial class Pantalla1View : TabbedPage
{
    PrincipalViewModel principalViewModel;
	public Pantalla1View()
	{
        InitializeComponent();
        principalViewModel = new PrincipalViewModel();
        BindingContext = principalViewModel;
    }

    private void agregar_Clicked(object sender, EventArgs e)
    {
        Pantalla3View pantalla3View = new Pantalla3View(principalViewModel);
        Navigation.PushAsync(pantalla3View);
    }

    private void listaContactos_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void favoritos_Clicked(object sender, EventArgs e)
    {
        Pantalla2View pantalla2View = new Pantalla2View(principalViewModel);
        Navigation.PushAsync(pantalla2View);
    }

    private void contacto_Clicked(object sender, EventArgs e)
    {
        Pantalla4View pantalla4View = new Pantalla4View(principalViewModel);
        Navigation.PushAsync(pantalla4View);
    }
}