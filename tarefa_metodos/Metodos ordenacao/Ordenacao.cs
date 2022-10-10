using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_ordenacao
{
    internal class Ordenacao
    {

        /*
         * Agitação
            Bolha
            Heap
            Inserção
            Merge
            Pente
            Quick
            Seleção
            Shell
         * 
         */

        private string info;
        private string metodo;

        //private Dictionary<string, Func<List<int>>> metodos;
        public Dictionary<string, Delegate> metodos = new Dictionary<string, Delegate>();
        

        public string Info { get { return info; } }

        public Ordenacao(String metodo)
        {
            metodos["Agitação"] = new Action<List<int>>(shake_sort);
            metodos["Bolha"] = new Action<List<int>>(bubble_sort);
            metodos["Heap"] = new Action<List<int>>(heap_sort);
            metodos["Inserção"] = new Action<List<int>>(insertion_sort);
            metodos["Merge"] = new Action<List<int>, int, int>(merge_sort);
            metodos["Pente"] = new Action<List<int>>(comb_sort);
            metodos["Quick"] = new Action<List<int>, int, int>(quick_sort);
            metodos["Seleção"] = new Action<List<int>>(selection_sort);
            metodos["Shell"] = new Action<List<int>>(shell_sort);

            this.metodo = metodo;

            this.info = "Nome: " + this.metodo + Environment.NewLine;

            switch (metodo)
            {
                case "Agitação":
                    info += "Nome em inglês: Shake sort" + Environment.NewLine;
                    info += "Complexidade geral: O(n²)" + Environment.NewLine;
                    info += "Estabilidade: não-estável";
                    break;

                case "Bolha":
                    info += "Nome em inglês: Bubble sort" + Environment.NewLine;
                    info += "Complexidade geral: O(n²)" + Environment.NewLine;
                    info += "Estabilidade: estável";
                    break;

                case "Heap":
                    info += "Nome em inglês: Heapsort" + Environment.NewLine;
                    info += "Complexidade geral: O(n * log n)" + Environment.NewLine;
                    info += "Estabilidade: não-estável" + Environment.NewLine;
                    info += "Data: 1964";
                    break;

                case "Inserção":
                    info += "Nome em inglês: Insertion sort" + Environment.NewLine;
                    info += "Complexidade geral: O(n²)" + Environment.NewLine;
                    info += "Estabilidade: estável";
                    break;

                case "Merge":
                    info += "Nome em inglês: Merge sort" + Environment.NewLine;
                    info += "Complexidade geral: O(n * log n)" + Environment.NewLine;
                    info += "Estabilidade: estável" + Environment.NewLine;
                    info += "Data: 1945" + Environment.NewLine;
                    info += "Criador: John Von Neumann";
                    break;

                case "Pente":
                    info += "Nome em inglês: Comb sort" + Environment.NewLine;
                    info += "Complexidade geral: O(n * log n)" + Environment.NewLine;
                    info += "Estabilidade: não-estável" + Environment.NewLine;
                    info += "Data: 1980" + Environment.NewLine;
                    info += "Criador: Wlodzimierz Dobosiewicz";
                    break;

                case "Quick":
                    info += "Nome em inglês: Quick sort" + Environment.NewLine;
                    info += "Complexidade geral: O(n * log n)" + Environment.NewLine;
                    info += "Estabilidade: não-estável" + Environment.NewLine;
                    info += "Data: 1960" + Environment.NewLine;
                    info += "Criador: Charles Antony Richard Hoare";
                    break;

                case "Seleção":
                    info += "Nome em inglês: Selection sort" + Environment.NewLine;
                    info += "Complexidade geral: O(n²)" + Environment.NewLine;
                    info += "Estabilidade: não-estável";
                    break;

                case "Shell":
                    info += "Nome em inglês: Shell sort" + Environment.NewLine;
                    info += "Complexidade geral: O(n * log n)" + Environment.NewLine;
                    info += "Estabilidade: não-estável" + Environment.NewLine;
                    info += "Data: 1959" + Environment.NewLine;
                    info += "Criador: Donald Shell";
                    break;

                default:
                    info = "";
                    break;

            }

        }

        public void ordenar(List<int> lista)
        {
            if (this.metodo != "Quick" && this.metodo != "Merge")
                metodos[this.metodo].DynamicInvoke(lista);
            else
                metodos[this.metodo].DynamicInvoke(lista, 0, lista.Count-1);


        }

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
            bool houveTroca;

            do
            {

                houveTroca = false;

                for (int i = ini; i < fim; i++)
                {
                    if (lista[i] > lista[i + 1])
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

        public static void comb_sort(List<int> lista)
        {
            int tam = lista.Count;
            int dist = tam;
            bool houve_troca = true;

            do
            {

                dist = (int)(dist / 1.3);

                if (dist < 1) dist = 1;

                houve_troca = false;

                for (int i = 0; i + dist < tam; i++)
                {

                    if (lista[i] > lista[i + dist])
                    {

                        int aux = lista[i];
                        lista[i] = lista[i + dist];
                        lista[i + dist] = aux;

                        houve_troca = true;

                    }

                }


            } while (dist > 1 || houve_troca);
        }


        public static void shell_sort(List<int> lista)
        {
            int i, j, distancia = 1;
            int tmp;
            int referenciaTamanho = 3;

            do
            {
                distancia = referenciaTamanho * distancia + 1;
            } while (distancia < lista.Count);

            do
            {
                distancia = (int)((float)distancia / referenciaTamanho);

                for (i = distancia; i < lista.Count; i++)
                {
                    tmp = lista[i];
                    for (j = i - distancia; j >= 0; j = j - distancia)
                    {
                        if (tmp < lista[j])
                        {
                            lista[j + distancia] = lista[j];
                        }
                        else break;
                    }
                    lista[j + distancia] = tmp;
                }

            } while (distancia > 1);
        }

        private static int posicionaPivo(List<int> lista, int ini, int fim)
        {
            int pivo;
            int tmp;
            Random r = new Random();
            pivo = r.Next(ini, fim); //na bibliografia do método, é possível ser o ini, o fim ou uma posição sorteada
            while (fim > ini)
            {

                for (; fim > pivo && lista[fim] > lista[pivo]; fim--) ;

                if (fim > pivo)
                {
                    tmp = lista[pivo];
                    lista[pivo] = lista[fim];
                    lista[fim] = tmp;
                    pivo = fim;
                }

                for (ini++; ini < pivo && lista[ini] < lista[pivo]; ini++) ;

                if (ini < pivo)
                {
                    tmp = lista[pivo];
                    lista[pivo] = lista[ini];
                    lista[ini] = tmp;
                    pivo = ini;
                }
            }
            return pivo;
        }

        public static void quick_sort(List<int> lista, int ini, int fim)
        {
            int pivo;

            pivo = posicionaPivo(lista, ini, fim);

            if (ini < pivo - 1)
                quick_sort(lista, ini, pivo - 1); //se existe lado esq do pivo, executa lado esq
            if (pivo + 1 < fim)
                quick_sort(lista, pivo + 1, fim); //se existe lado dir do pivo, executa lado dir
        }

        public static void heap_sort(List<int> lista)
        {
            int tmp;
            int i;
            int n = lista.Count;


            while (n > 1)
            {
                for (i = (int)n / 2 - 1; i > 0; i--)
                {
                    if (lista[i] < lista[i * 2])
                    { //comparando o raiz com seu filho da esquerda
                        tmp = lista[i];
                        lista[i] = lista[i * 2];
                        lista[i * 2] = tmp;
                    }
                    if (i * 2 + 1 <= n)
                    { //só vamos comparar o filho da direita se ele existir
                        if (lista[i] < lista[i * 2 + 1])
                        { //comparando o raiz com seu filho da direita
                            tmp = lista[i];
                            lista[i] = lista[i * 2 + 1];
                            lista[i * 2 + 1] = tmp;
                        }
                    }
                }
                tmp = lista[1];
                lista[1] = lista[n - 1];
                lista[n - 1] = tmp;
                n--;
            }
        }

        public void merge_sort(List<int> lista, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                merge_sort(lista, left, middle);
                merge_sort(lista, middle + 1, right);
                MergeArray(lista, left, middle, right);
            }

        }

        public void MergeArray(List<int> array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

    }

}
