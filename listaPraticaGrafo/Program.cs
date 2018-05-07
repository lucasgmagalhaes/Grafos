using System;
using listaPraticaGrafo.utils;

namespace listaPraticaGrafo
{
    class Program
    {
        static void Main(string[] args)
        {

            LeitorArquivo leitor = new LeitorArquivo();
            string[] linhas = leitor.lerArquivo("grafo.txt");
            Grafo grafo = new Grafo();
            grafo.GerarGrafo(linhas);

            grafo = new Digrafo(FileArray.GRAFO01_DIRIGIDO);

            //Console.WriteLine(grafo.GetAGMPrimFormatado());
            //Console.CursorVisible = false;

            Console.WriteLine(grafo.ToStringSimplesSemEspaco());

            Console.ReadKey();

        }
    }
}
