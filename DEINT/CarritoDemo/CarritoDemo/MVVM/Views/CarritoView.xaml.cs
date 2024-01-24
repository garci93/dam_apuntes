using CarritoDemo.MVVM.Models;
using CarritoDemo.MVVM.ViewModels;

namespace CarritoDemo.MVVM.Views;

public partial class CarritoView : ContentPage
{
	public CarritoView()
	{
		InitializeComponent();
        BindingContext = new CarritoViewModel();
    }

    private void botonMenos_Clicked(object sender, EventArgs e)
    {

    }

    private void botonMas_Clicked(object sender, EventArgs e)
    {

    }
}