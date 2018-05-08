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
            //grafo.GerarGrafo(linhas);

            grafo = new Digrafo(FileArray.GRAFO01_DIRIGIDO);

            //Console.WriteLine(grafo.GetAGMPrimFormatado());
            //Console.CursorVisible = false;

            Console.WriteLine(grafo.ToString());

            StringBuilder str;
            IGrafo agm = grafo.GetAGMPrim(out str);

            //Console.WriteLine("\n\nOrdem de Kruskal = " + str);
            //Console.WriteLine("\nKruskal:\n" + agm.ToString());

            Console.WriteLine("\n\nOrdem de Prim = " + str);
            Console.WriteLine("\nPrim:\n" + agm.ToString());

            Console.CursorVisible = false;
            Console.ReadKey();

        }
    }
}
