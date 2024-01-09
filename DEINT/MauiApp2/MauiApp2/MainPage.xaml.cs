namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private double porcentajePropina = 0.0;
        private double sliderValue = 0.0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void boton10_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                porcentajePropina = double.Parse(button.Text.Trim('%'));
                CalcularPropina(porcentajePropina);
            }
        }

        private void boton15_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                porcentajePropina = double.Parse(button.Text.Trim('%'));
                CalcularPropina(porcentajePropina);
            }
        }

        private void boton20_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                porcentajePropina = double.Parse(button.Text.Trim('%'));
                CalcularPropina(porcentajePropina);
            }
        }

        private void botonMenos_Clicked(object sender, EventArgs e)
        {
            int personas = int.Parse(numPersonas.Text);
            if (personas > 1)
            {
                numPersonas.Text = (personas - 1).ToString();
                CalcularTotal();
            }
        }

        private void botonMas_Clicked(object sender, EventArgs e)
        {
            int personas = int.Parse(numPersonas.Text);
            numPersonas.Text = (personas + 1).ToString();

            CalcularTotal();
        }

        private void sliderPropina_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            sliderValue = sliderPropina.Value;
            CalcularPropina(sliderValue);
            labelPorcPropina.Text = $"Propina: {sliderValue.ToString()} %";
        }

        private void CalcularPropina(double porcentaje)
        {
            double subtotal = double.Parse(cuentaEur.Text);
            double propina = subtotal * (porcentaje / 100);
            propinaEur.Text = $"{propina.ToString("0.00")}€";

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            int personas = int.Parse(numPersonas.Text);
            double subtotal = double.Parse(cuentaEur.Text) / personas;

            double propina = double.Parse(propinaEur.Text.Trim('€'));
            double total = subtotal + propina;

            totalEur.Text = $"{total.ToString("0.00")}€";
            subtotalEur.Text = $"{subtotal.ToString("0.00")}€";
        }
    }

}
