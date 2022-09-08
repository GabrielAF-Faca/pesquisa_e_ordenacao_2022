namespace aula_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button_gerar_Click(object sender, EventArgs e)
        {

            

            lista.Clear();
            Random rand = new Random();
            

            try
            {
                long qtdNumeros = long.Parse(textBox_qtdDados.Text);

                Dado dado;

                for (; qtdNumeros > 0; qtdNumeros--)
                {
                    dado = new Dado(rand.Next(0, 100), rand.Next(0, 500));

                    lista.Add( dado );

                    textBox_dados.AppendText(dado.Chave1 + " - " + dado.Chave2 + Environment.NewLine);

                }



            } catch (FormatException) {

                MessageBox.Show("Tipo de dados inválido na text box", "Alerta");

            }

            //Limpa os dados da textbox quando clica no botão gerar
            textBox_qtdDados.Text = "";
        }

        List<Dado> lista = new List<Dado>();

    }
}