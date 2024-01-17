using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class CommandView : ContentPage
{
	public CommandView()
	{
		InitializeComponent();
		BindingContext = new CommandViewModel();
	}
}