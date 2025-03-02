namespace CalculadoraWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float numero1;
        float numero2;
        float resultado;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {

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
    }
}
