namespace WinFormsOrdenacao
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox_qtdNumeros.Text.Length > 0)
            {
                Random gerador = new Random();

            } else
            {
                MessageBox.Show("Quantidade de números não definida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            



        }
        List<string> lista = new List<string>();
    }
}