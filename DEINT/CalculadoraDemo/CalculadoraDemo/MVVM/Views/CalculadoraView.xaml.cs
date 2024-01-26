using CalculadoraDemo.MVVM.ViewModels;

namespace CalculadoraDemo.MVVM.Views;

public partial class CalculadoraView : ContentPage
{
	public CalculadoraView()
	{
		InitializeComponent();
		BindingContext = new CalculadoraViewModel();
	}
}