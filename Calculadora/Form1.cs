namespace Calculadora
{
    public partial class btnMultiplicar : Form
    {
        public btnMultiplicar()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultado.Text = Int32.Parse(txtCampo1.Text) + Int32.Parse(txtCampo2.Text) + "";
            }
            catch (Exception ex)
            {
                txtResultado.Text = "aí nÃO DÁ NÉ";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCampo1.Text = "";
            txtCampo2.Text = "";
            txtResultado.Text = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int resultado;
            int campo1 = TransformarNumero(txtCampo1.Text);
            int campo2 = TransformarNumero(txtCampo2.Text);
            resultado = campo1 - campo2;
            txtResultado.Text = resultado.ToString();
        }



        int TransformarNumero(string numeroASerTransformado)
        {
            return int.Parse(numeroASerTransformado);
        }
    }
}