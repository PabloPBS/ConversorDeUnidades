namespace ConversorDeUnidades
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularDistancia(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(distanciaEntry.Text))
            {
                double valor = double.Parse(distanciaEntry.Text);
                string origem =  DistanciaOrigem.SelectedItem.ToString();
                string destino = DistanciaDestino.SelectedItem.ToString();

                double resultado = ConverterDistancia(valor, origem, destino);
                resultadoDistancia.Text = $"Resultado: {resultado} {destino}";
            }
        }

        private double ConverterDistancia(double valor, string origem, string destino)
        {
            double metros = valor;

            if (origem == "Quilômetros") metros = valor * 1000;
            else if (origem == "Centímetros") metros = valor / 100;

            if (destino == "Quilômetros") return metros / 1000;
            else if (destino == "Centímetros") return metros * 100;

            return metros;
        }


        private void CalcularPeso(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pesoEntry.Text))
            {
                double valor = double.Parse(pesoEntry.Text);
                string origem = unidadeOrigemPeso.SelectedItem.ToString();
                string destino = unidadeDestinoPeso.SelectedItem.ToString();

                double resultado = ConverterPeso(valor, origem, destino);
                resultadoPeso.Text = $"Resultado: {resultado} {destino}";
            }
        }

        private double ConverterPeso(double valor, string origem, string destino)
        {
            double gramas = valor;

            if (origem == "Kg") gramas = valor * 1000;
            else if (origem == "Lb") gramas = valor * 453.592;

            if (destino == "Kg") return gramas / 1000;
            else if (destino == "Lb") return gramas / 453.592;

            return gramas;
        }

        private void CalcularTemperatura(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(temperaturaEntry.Text))
            {
                double valor = double.Parse(temperaturaEntry.Text);
                string origem = unidadeOrigemTemperatura.SelectedItem.ToString();
                string destino = unidadeDestinoTemperatura.SelectedItem.ToString();

                double resultado = ConverterTemperatura(valor, origem, destino);
                resultadoTemperatura.Text = $"Resultado: {resultado} {destino}";
            }
        }

        private double ConverterTemperatura(double valor, string origem, string destino)
        {
            double celsius = valor;

            if (origem == "Fahrenheit") celsius = (valor - 32) * 5 / 9;
            else if (origem == "Kelvin") celsius = valor - 273.15;

            if (destino == "Fahrenheit") return celsius * 9 / 5 + 32;
            else if (destino == "Kelvin") return celsius + 273.15;

            return celsius;
        }
    }
}
