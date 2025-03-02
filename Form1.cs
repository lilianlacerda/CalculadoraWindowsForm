namespace CalculadoraWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float numero1;
        private float numero2;
        private float resultado;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            ConverterValoresFloat();
            resultado = Somar(numero1, numero2);
            label1.Text = $"{numero1} + {numero2} = {resultado}";
            ValidarCampos();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            ConverterValoresFloat();
            resultado = Subtrair(numero1, numero2);
            label1.Text = $"{numero1} - {numero2} = {resultado}";
            ValidarCampos();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            ConverterValoresFloat();
            resultado = Multiplicar(numero1, numero2);
            label1.Text = $"{numero1} * {numero2} = {resultado}";
            ValidarCampos();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            ConverterValoresFloat();
            resultado = Dividir(numero1, numero2);
            label1.Text = $"{numero1} / {numero2} = {resultado}";
            ValidarCampos();
        }

        private void resetarCalculo_Click(object sender, EventArgs e)
        {

        }

        private static float Somar(float numero1, float numero2)
        {
            float resultado = numero1 + numero2;
            return resultado;
        }

        private static float Subtrair(float numero1, float numero2)
        {
            float resultado = numero1 - numero2;
            return resultado;
        }

        private static float Multiplicar(float numero1, float numero2)
        {
            float resultado = numero1 * numero2;
            return resultado;
        }

        private static float Dividir(float numero1, float numero2)
        {
            float resultado = numero1 / numero2;
            return resultado;
        }

        private void ConverterValoresFloat()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(textBox2.Text))
            {
                numero1 = float.Parse(textBox1.Text);
                numero2 = float.Parse(textBox2.Text);
            }
        }

        private void ValidarCampos()
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                label1.Text = ("Preencha os campos corretamente!");
            }
        }
    }
}
