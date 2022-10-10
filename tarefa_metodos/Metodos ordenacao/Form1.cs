using System.Diagnostics;

namespace Metodos_ordenacao
{
    public partial class Form1 : Form
    {

        Ordenacao metodos;
        
        public Form1()
        {
            InitializeComponent();
            comboBox_metodos.SelectedIndex = 0;
        }

        private void button_limpa_qtd_Click(object sender, EventArgs e)
        {
            textBox_qtd_valores.Text = "";
            textBox_comportamento.Clear();
        }

        private void button_limpa_metodo_Click(object sender, EventArgs e)
        {
            comboBox_metodos.SelectedIndex = 0;
        }

        private void button_testar_Click(object sender, EventArgs e)
        {
            textBox_comportamento.Text = "";

            Random rand = new Random();

            List<int> numeros = new List<int>();

            int qtd = int.Parse(textBox_qtd_valores.Text);

            textBox_comportamento.AppendText("Quantidade de números: " + qtd + Environment.NewLine);

            for (int i = 0; i < qtd; i++)
            {

                numeros.Add(rand.Next(20)); 

            }

            Stopwatch sw = new Stopwatch();

            textBox_comportamento.AppendText("Iniciando ordenação..." + Environment.NewLine);

            sw.Start();
            metodos.ordenar(numeros);
            sw.Stop();
            textBox_comportamento.AppendText("Fim ordenação..." + Environment.NewLine);
            textBox_comportamento.AppendText("Tempo de execução: " + sw.ElapsedMilliseconds + " ms");
            sw.Restart();

        }


        private void comboBox_metodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            metodos = new Ordenacao(comboBox_metodos.Text);

            textBox_comportamento.Clear();

            textBox_metodo.Text = metodos.Info;

            panel_direita.Enabled = false;

            if (metodos.Info != "")
                panel_direita.Enabled = true;
               


        }

        private void textBox_qtd_valores_TextChanged(object sender, EventArgs e)
        {

            button_testar.Enabled = false;

            if (textBox_qtd_valores.Text.Length > 0)
                button_testar.Enabled = true;
        }
    }
}