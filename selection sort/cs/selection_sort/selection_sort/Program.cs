using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lista = new List<int>();

            Stopwatch sw = new Stopwatch();

            int qtdNumeros;
            Console.Write("Quantos números quer gerar? ");
            qtdNumeros = int.Parse(Console.ReadLine());

            Util.popularLista(lista, qtdNumeros);
            //Util.exibirLista(lista, "Lista original: ");

            sw.Start();
            //Ordenacao.selection_sort(lista);
            //Ordenacao.bubble_sort(lista);
            Ordenacao.insertion_sort(lista);
            sw.Stop();

            //Util.exibirLista(lista, "Lista ordenada por seleção: ");
            //Util.exibirLista(lista, "Lista ordenada por bolha: ");
            //Util.exibirLista(lista, "Lista ordenada por inserção: ");


            Console.WriteLine("Fim do seleção (ms): " + sw.ElapsedMilliseconds);
            sw.Reset();
        }
    }

}
