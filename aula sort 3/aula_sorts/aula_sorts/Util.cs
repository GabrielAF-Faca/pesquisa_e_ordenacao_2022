using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_sorts
{
    internal class Util
    {

        public static void popularDoArquivo(string nomeArquivo, List<int> lista)
        {

            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);

            do
            {
                int numero = int.Parse(leitor.ReadLine());
                lista.Add(numero);

            } while (!leitor.EndOfStream);

            leitor.Close();

        }
        
        public static void exibirLista(List<int> lista, string msg = "")
        { 
            Console.WriteLine(msg); 
            foreach (var item in lista)
            {
                Console.Write("["+item+"] ");

            }

        }

        public static void escreverArquivo(int quantidade)
        {
            try
            {
                String nomeArquivo;
                StreamWriter escritor;

                Console.Write("Digite o nome do arquivo que deseja gravar com os números: ");
                nomeArquivo = Console.ReadLine();
                escritor = new StreamWriter(nomeArquivo); //abre o arquivo para escrita

                Random gerador = new Random();
                for (int i = 0; i < quantidade; i++)
                {
                    escritor.WriteLine(gerador.Next(1000)); //literalmente escreve no arquivo
                    escritor.Flush(); //garante depois de cada numero gerado que vá para o arquivo
                }
                escritor.Close(); //fecha o objeto que representa o arquivo
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
                //Util.escreverArquivo(quantidade); //ponto de recursão - USAR COM CUIDADO
            }

        }


    }
}
