using P8AdministradorTareas.MVVM.ViewModels;

namespace P8AdministradorTareas.MVVM.Views;

public partial class TareaView : ContentPage
{
	public TareaView()
	{
		InitializeComponent();
        Title = "Mis tareas";
        BindingContext = new TareaViewModel();
	}

    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
    }
}