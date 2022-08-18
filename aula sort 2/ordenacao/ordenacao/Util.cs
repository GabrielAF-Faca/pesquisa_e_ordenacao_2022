using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenacao
{
    class Util
    {

        public static void exibir(List<int> lista, String frase)
        {

            Console.Write(frase);

            foreach (int i in lista)
            {
                Console.Write("[" + i + "] ");
            }

            Console.WriteLine("\n");

        }

    }
}
