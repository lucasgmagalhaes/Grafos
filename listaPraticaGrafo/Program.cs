using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using listaPraticaGrafo.Arquitetura.Estrutura;
using listaPraticaGrafo.Arquitetura.Interfaces;
using System.IO;
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

            grafo.GerarGrafo(FileArray.GRAFO2_NAO_DIRIGIDO);

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
