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
}