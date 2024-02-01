using P8AdministradorTareas.MVVM.ViewModels;

namespace P8AdministradorTareas.MVVM.Views;

public partial class TareaView : ContentPage
{
    private TareaViewModel vm;

    public TareaView()
	{
		InitializeComponent();
        Title = "Mis tareas";
        vm = new TareaViewModel();
        BindingContext = vm;
    }

    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
    }

    private async void Button_Pressed(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TareaView2(vm));
    }
}