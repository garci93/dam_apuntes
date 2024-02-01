using P8AdministradorTareas.MVVM.ViewModels;

namespace P8AdministradorTareas.MVVM.Views;

public partial class TareaView2 : ContentPage
{
	public TareaView2(TareaViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}