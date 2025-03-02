namespace CalculadoraWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float numero1;
        public float numero2;
        public float resultado;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            resultado = Somar(numero1, numero2);
            label1.Text = $"{numero1} + {numero2} = {resultado}";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            resultado = Subtrair(numero1, numero2);
            label1.Text = $"{numero1} - {numero2} = {resultado}";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            resultado = Multiplicar(numero1, numero2);
            label1.Text = $"{numero1} * {numero2} = {resultado}";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            resultado = Dividir(numero1, numero2);
            label1.Text = $"{numero1} / {numero2} = {resultado}";
        }

        public static float Somar(float numero1, float numero2)
        {
            float resultado = numero1 + numero2;
            return resultado;
        }

        public static float Subtrair(float numero1, float numero2)
        {
            float resultado = numero1 - numero2;
            return resultado;
        }

        public static float Multiplicar(float numero1, float numero2)
        {
            float resultado = numero1 * numero2;
            return resultado;
        }

        public static float Dividir(float numero1, float numero2)
        {
            float resultado = numero1 / numero2;
            return resultado;
        }

        private void ConverterValoresFloat()
        {
            numero1 = float.Parse(textBox1.Text);
            numero2 = float.Parse(textBox2.Text);
        }

        private void ValidarCampos()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                label1.Text = ("Preencha os campos corretamente!");
            }
            else
            {
                ConverterValoresFloat();
            }
        }
    }
}
