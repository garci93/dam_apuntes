namespace ColorPicker;

public partial class PaginaInicio : ContentPage
{
	public PaginaInicio()
	{
		InitializeComponent();
        
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int valorSliderRed = (int)sliderRed.Value;
        int valorSliderGreen = (int)sliderGreen.Value;
        int valorSliderBlue = (int)sliderBlue.Value;


        BackgroundColor = Color.FromRgb(valorSliderRed,valorSliderGreen,valorSliderBlue);
        hexValue.Text = $"Hex Value: #{valorSliderRed:x2}{valorSliderGreen:x2}{valorSliderBlue:x2}";
    }
private void randomColor_Clicked(object sender, EventArgs e)
    {
        Random random = new Random();
        int valorRed = random.Next(256);
        int valorGreen = random.Next(256);
        int valorBlue = random.Next(256);


        BackgroundColor = Color.FromRgb(valorRed, valorGreen, valorBlue);
        sliderRed.Value = valorRed;
        sliderGreen.Value = valorGreen;
        sliderBlue.Value = valorBlue;

        hexValue.Text = $"Hex Value: #{valorRed:x2}{valorGreen:x2}{valorBlue:x2}";
    }
}