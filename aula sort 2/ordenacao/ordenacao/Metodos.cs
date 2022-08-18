using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenacao
{
    class Metodos
    {
        public static void selection_sort(List<int> lista)
        {
            int i, j, tmp, posMenor;

            int tam = lista.Count;

            for (i = 0; i < tam - 1; i++)
            {

                posMenor = i;

                for (j = i + 1; j < tam; j++)
                {

                    if (lista[j] < lista[posMenor])
                    {

                        posMenor = j;

                    }

                }

                if (i != posMenor)
                {

                    tmp = lista[i];
                    lista[i] = lista[posMenor];
                    lista[posMenor] = tmp;

                }


            }

        }

        /// <summary>
        /// Método para utilizar a ordenação Bubble
        /// </summary>
        /// <param name="lista">Lista de inteiros</param>
        public static void bubble_sort(List<int> lista)
        {

            int i, tmp;
            bool houveTroca;

            do
            {

                houveTroca = false;

                for (i = 0; i < lista.Count - 1; i++)
                {

                    if (lista[i] > lista[i + 1])
                    {
                        houveTroca = true;

                        tmp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = tmp;

                    }

                }


            } while (houveTroca);


        }
        /// <summary>
        /// Método para utilizar a ordenação Insertion
        /// </summary>
        /// <param name="lista">Lista de inteiros</param>
        public static void insertion_sort(List<int> lista)
        {

            int i, j, tmp;

            for (i = 1; i < lista.Count; i++)
            {

                tmp = lista[i];

                for (j = i - 1; j >= 0 && tmp < lista[j]; j--)
                {
                    lista[j + 1] = lista[j];
                }

                lista[j + 1] = tmp;


            }

        }
        public static void shake_sort(List<int> lista)
        {

            int ini = 0, fim = lista.Count - 1;
            bool houveTroca = false;

            do {

                houveTroca = false;

                for (int i = ini; i < fim; i++)
                { 
                    if (lista[i] > lista[i+1])
                    {

                        int aux = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = aux;
                        houveTroca = true;

                    }

                }

                if (!houveTroca) break;

                fim--;

                houveTroca = false;

                for (int i = fim; i > ini; i--)
                {
                    if (lista[i] < lista[i - 1])
                    {

                        int aux = lista[i];
                        lista[i] = lista[i - 1];
                        lista[i - 1] = aux;
                        houveTroca = true;

                    }

                }

                ini++;

            } while (houveTroca && ini <= fim);

        }

    }
}
