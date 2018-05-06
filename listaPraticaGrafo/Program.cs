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
            grafo.GerarGrafo(linhas);

            Aresta a = new Aresta(null, null, 10);
            Console.WriteLine(a.GetPeso());
            //grafo.GerarGrafo(FileArray.GRAFO1_NAO_DIRIGIDO);
            //Console.WriteLine(grafo.GetAGMPrimFormatado());
            //Console.CursorVisible = false;

            Console.WriteLine(grafo.GetComplementar().ToString());

            Console.ReadKey();

        }
    }
}
