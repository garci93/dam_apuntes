using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class FodyDemo : ContentPage
{
	public FodyDemo()
	{
		InitializeComponent();
		BindingContext = new FodyDemoModel();
	}
}