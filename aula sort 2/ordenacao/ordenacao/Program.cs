using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ordenacao
{
    class Program
    {
        public static List<int> listaBolha = new List<int>();
        public static List<int> listaSelecao = new List<int>();
        public static List<int> listaInsercao = new List<int>();
        public static List<int> listaAgitacao = new List<int>();
        public static List<int> listaBolhaT = new List<int>();
        public static List<int> listaSelecaoT = new List<int>();
        public static List<int> listaInsercaoT = new List<int>();
        public static List<int> listaAgitacaoT = new List<int>();
        static void Main(string[] args)
        {

            

            Random rand = new Random();

            for (int i = 0; i < 20000; i++)
            {
                int valor = rand.Next(0, 500);

                listaBolha.Add(valor);
                listaSelecao.Add(valor);
                listaInsercao.Add(valor);
                listaAgitacao.Add(valor);
                listaBolhaT.Add(valor);
                listaSelecaoT.Add(valor);
                listaInsercaoT.Add(valor);
                listaAgitacaoT.Add(valor);

            }

            //Util.exibir(listaBolha, "Bolha:\n");
            //Util.exibir(listaSelecao, "Selecao:\n");
            //Util.exibir(listaInsercao, "Insercao:\n");
            //Util.exibir(listaAgitacao, "Agitacao:\n");

           Console.WriteLine("### SEM THREAD ###\n");
           semThread();            

            Console.WriteLine("\n### COM THREAD ###\n");
            comThread();

            


            //Console.WriteLine("\n\nDepois do sort\n\n");

            //Util.exibir(listaBolha, "Bolha:\n");
            //Util.exibir(listaSelecao, "Selecao:\n");
            //Util.exibir(listaInsercao, "Insercao:\n");
            //Util.exibir(listaAgitacao, "Agitacao:\n");

        }

        public static void comThread()
        { 

            new Thread(() =>
            {
                DateTime inicio = DateTime.UtcNow;
                Metodos.bubble_sort(listaBolhaT);
                DateTime fim = DateTime.UtcNow;
                TimeSpan elapsedTime = fim.Subtract(inicio);
                long unixTimstamp = (long)elapsedTime.TotalMilliseconds;               
                Console.WriteLine("Fim do bolha (ms): " + unixTimstamp);
            }).Start();

            new Thread(() =>
            {
                Stopwatch sw1 = new Stopwatch();
                sw1.Start();
                Metodos.selection_sort(listaSelecaoT);
                sw1.Stop();
                Console.WriteLine("Fim do selecao (ms): " + sw1.ElapsedMilliseconds);
                sw1.Reset();

            }).Start();

            new Thread(() =>
            {
                Stopwatch sw2 = new Stopwatch();
                sw2.Start();
                Metodos.insertion_sort(listaInsercaoT);
                sw2.Stop();
                Console.WriteLine("Fim do insercao (ms): " + sw2.ElapsedMilliseconds);
                sw2.Reset();

            }).Start();

            new Thread(() =>
            {
                Stopwatch sw3 = new Stopwatch();
                sw3.Start();
                Metodos.shake_sort(listaAgitacaoT);
                sw3.Stop();
                Console.WriteLine("Fim do agitacao (ms): " + sw3.ElapsedMilliseconds);
                sw3.Reset();

            }).Start();
        }

        public static void semThread()
        {
            Stopwatch sw = new Stopwatch();

            DateTime inicio = DateTime.UtcNow;
            Metodos.bubble_sort(listaBolha);
            DateTime fim = DateTime.UtcNow;
            TimeSpan elapsedTime = fim.Subtract(inicio);
            long unixTimstamp = (long)elapsedTime.TotalMilliseconds;
            Console.WriteLine("Fim do bolha (ms): " + unixTimstamp);

            sw.Start();
            Metodos.selection_sort(listaSelecao);
            sw.Stop();
            Console.WriteLine("Fim do selecao (ms): " + sw.ElapsedMilliseconds);
            sw.Reset();

            sw.Start();
            Metodos.insertion_sort(listaInsercao);
            sw.Stop();
            Console.WriteLine("Fim do insercao (ms): " + sw.ElapsedMilliseconds);
            sw.Reset();

            sw.Start();
            Metodos.shake_sort(listaAgitacao);
            sw.Stop();
            Console.WriteLine("Fim do agitacao (ms): " + sw.ElapsedMilliseconds);
            sw.Reset();


        }

    }
}
