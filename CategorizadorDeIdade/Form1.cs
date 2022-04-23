namespace CategorizadorDeIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            int idade;
            try
            {
                 idade = int.Parse(txtIdade.Text);

            }
            catch (Exception ex)
            {
                lblResposta.Text = "Em que mundo \"" + txtIdade.Text + "\" é uma idade?";
                return;
            }
            if (idade > 0 && idade < 10)
            {
                lblResposta.Text = "Nossa,  é uma criança!";

            }
            else if (idade < 18)
            {
                lblResposta.Text = "Muito jovem!";
            }
            else if (idade == 18)
            {
                lblResposta.Text = "Ui, tá no grau!";
            }
            else if (idade < 30)
            {
                lblResposta.Text = "Tá na flor da idade!";
            }
            else if (idade < 40)
            {
                lblResposta.Text = "Trintão ein!";
            }
            else if (idade < 50)
            {
                lblResposta.Text = "Tá bom de se aquietar!";
            }
            else if (idade < 60)
            {
                lblResposta.Text = "Tá acabando o gás!";
            }
            else if (idade > 60 && idade < 100)
            {
                lblResposta.Text = "Vai se despedindo da galera, que a qualquer hora tu vai!";
            }
            else
            {
                lblResposta.Text = "DUVIDOOOOOO!";
            }
            txtIdade.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResposta.Text = "";
        }
    }
}