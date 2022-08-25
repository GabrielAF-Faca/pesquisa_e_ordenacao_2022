// See https://aka.ms/new-console-template for more information
using aula_sorts;
using System.Diagnostics;

List<int> listaBolha = new List<int>();
List<int> listaSelecao = new List<int>();
List<int> listaInsercao = new List<int>();
List<int> listaAgitacao = new List<int>();
List<int> listaPente = new List<int>();

//Util.escreverArquivo(50000*2);

Util.popularDoArquivo("C:/temp/numeros.txt", listaBolha);

listaSelecao.AddRange(listaBolha);
listaInsercao.AddRange(listaBolha);
listaAgitacao.AddRange(listaBolha);
listaPente.AddRange(listaBolha);

Stopwatch sw = new Stopwatch();

//sw.Start();
//Ordenacao.bubble_sort(listaBolha);
//sw.Stop();
//Console.WriteLine("Bolha (ms): " + sw.ElapsedMilliseconds);
//sw.Reset();


//sw.Start();
//Ordenacao.shake_sort(listaAgitacao);
//sw.Stop();
//Console.WriteLine("Agitacao (ms): " + sw.ElapsedMilliseconds);
//sw.Reset();


//sw.Start();
//Ordenacao.selection_sort(listaSelecao);
//sw.Stop();
//Console.WriteLine("Selecao (ms): " + sw.ElapsedMilliseconds);
//sw.Reset();


//sw.Start();
//Ordenacao.insertion_sort(listaInsercao);
//sw.Stop();
//Console.WriteLine("Insercao (ms): " + sw.ElapsedMilliseconds);
//sw.Reset();


sw.Start();
Ordenacao.comb_sort(listaPente);
sw.Stop();
Console.WriteLine("Pente (ms): " + sw.ElapsedMilliseconds);
sw.Reset();