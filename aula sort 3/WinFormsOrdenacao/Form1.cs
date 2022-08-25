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
        List<int> lista = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox_qtdNumeros.Text.Length > 0)
            {
                Random gerador = new Random();
                int numero;
                for (int i = 0; i < int.Parse(textBox_qtdNumeros.Text); i++)
                {
                    numero = gerador.Next(1, 500);
                    lista.Add(numero);
                    textBox_listarNumeros.AppendText("["+numero.ToString()+"] ");
                } 


            } else
            {
                MessageBox.Show("Quantidade de números não definida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}