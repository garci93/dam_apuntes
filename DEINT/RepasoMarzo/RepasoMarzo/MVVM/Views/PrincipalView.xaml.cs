namespace RepasoMarzo.MVVM.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
        BindingContext = new ContactoViewModel();
	}
}