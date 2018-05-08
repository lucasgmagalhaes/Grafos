using System;
using listaPraticaGrafo.utils;
using System.Text;
using listaPraticaGrafo.Arquitetura.Estrutura;

namespace listaPraticaGrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            LeitorArquivo leitor = new LeitorArquivo();
            StringBuilder builder = new StringBuilder();
            Grafo grafo;

            Console.CursorVisible = false;
            Console.Write("Digite o nome do arquivo: ");
            string filename = Console.ReadLine();

            string[] arquivo = leitor.lerArquivo(filename);

            if (Grafo.IsFileAGrafo(arquivo))
            {
                grafo = new Grafo(arquivo);

                Console.WriteLine("Grafo completo:");
                Console.WriteLine(grafo.ToString());

                Console.Write("isAdjacente(): vertice1{" + grafo.GetVertices[0].GetDadoValor()
                    + "} vertice2{" + grafo.GetVertices[1].GetDadoValor() + "}  ");
                Console.WriteLine(grafo.IsAdjacente(grafo.GetVertices[0], grafo.GetVertices[1]));

                Console.Write("GetGrau(): vertice1{" + grafo.GetVertices[0].GetDadoValor() + "}  ");
                Console.WriteLine(grafo.GetGrau(grafo.GetVertices[0]));

                Console.Write("IsIsolado(): vertice1{" + grafo.GetVertices[0].GetDadoValor() + "}  ");
                Console.WriteLine(grafo.IsIsolado(grafo.GetVertices[0]).ToString());

                Console.Write("IsPendente(): vertice1{" + grafo.GetVertices[0].GetDadoValor() + "}  ");
                Console.WriteLine(grafo.IsPendente(grafo.GetVertices[0]).ToString());

                Console.Write("IsRegular(): ");
                Console.WriteLine(grafo.IsRegular().ToString());

                Console.Write("IsNulo(): ");
                Console.WriteLine(grafo.IsNulo().ToString());

                Console.Write("IsCompleto(): ");
                Console.WriteLine(grafo.IsCompleto().ToString());

                Console.Write("IsConexo(): ");
                Console.WriteLine(grafo.IsConexo().ToString());

                Console.Write("IsEuleriano(): ");
                Console.WriteLine(grafo.IsEuleriano().ToString());

                Console.Write("IsUnicursal(): ");
                Console.WriteLine(grafo.IsUnicursal().ToString());

                Console.WriteLine("GetComplementar()");
                Console.WriteLine(grafo.GetComplementar().ToStringSimplesSemEspaco());

                grafo.GetAGMKruskal(out builder);
                Console.WriteLine("Kruskal: ");
                Console.WriteLine(builder.ToString());

                builder.Clear();
                grafo.GetAGMPrim(out builder)
                    ;
                Console.WriteLine("Prim: ");
                Console.WriteLine(builder.ToString());
            }
            else if (Digrafo.IsFileADigrafo(arquivo))
            {
               Digrafo digrafo = new Digrafo(arquivo);

                Console.Write("GetGrauEntrada(): vertice1{" + digrafo.GetVertices[0].GetDadoValor() + "} ");
                Console.WriteLine(digrafo.GetGrauEntrada((VerticeDirigido) digrafo.GetVertices[0]));

                Console.Write("GetGrauSaida(): vertice1{" + digrafo.GetVertices[0].GetDadoValor() + "}  ");
                Console.WriteLine(digrafo.GetGrauSaida((VerticeDirigido)digrafo.GetVertices[0]));

                Console.Write("HasCiclo()" + " ");
                Console.WriteLine(digrafo.HasCiclo());
            }
            else
            {
                Console.Write("FALHA NA LEITURA DO ARQUIVO");
            }
            Console.ReadKey();
        }
    }
}
