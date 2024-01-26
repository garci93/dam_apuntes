using ExamenMAUIJoseJoaquin.MVVM.ViewModels;

namespace ExamenMAUIJoseJoaquin.MVVM.Views;

public partial class PedidoView : ContentPage
{
	public PedidoView()
	{
		InitializeComponent();
        BindingContext = new PedidoViewModel();
    }
}