using P8AdministradorTareas.MVVM.ViewModels;

namespace P8AdministradorTareas.MVVM.Views;

public partial class TareaView : ContentPage
{
	public TareaView()
	{
		InitializeComponent();
		BindingContext = new TareaViewModel();
	}
}