using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    class Util
    {

        public static void popularLista(List<int> lista, int n)
        {

            Random gerador = new Random();

            for (; n > 0; n--)
            {

                lista.Add(gerador.Next(0, 500));

            }


        }

        public static void exibirLista(List<int> lista, String str)
        {

            Console.WriteLine(str);

            foreach (var i in lista)
            {

                Console.Write("[" + i + "] ");

            }

            Console.WriteLine();

        }

    }
}
