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
            Grafo grafo, agm;

            Console.CursorVisible = false;
            Console.Write("Digite o nome do arquivo: ");
            //string filename = Console.ReadLine();

            string[] arquivo = FileArray.GRAFO3_NAO_DIRIGIDO;

            if (Grafo.IsFileAGrafo(arquivo))
            {
                grafo = new Grafo(arquivo);

                Console.WriteLine("Grafo Original:\n" + grafo.ToString());

                //Console.WriteLine("Grafo completo:");
                //Console.WriteLine(grafo.ToString());

                ////grafo.GetCutVertices();
                //Console.Write("isAdjacente(): vertice1{" + grafo.GetVertice(0).GetDadoValor()
                //    + "} vertice2{" + grafo.GetVertice(1).GetDadoValor() + "}  ");
                //Console.WriteLine(grafo.IsAdjacente(grafo.GetVertice(0), grafo.GetVertice(1)));

                //Console.Write("GetGrau(): vertice1{" + grafo.GetVertice(0).GetDadoValor() + "}  ");
                //Console.WriteLine(grafo.GetGrau(grafo.GetVertice(0)));

                //Console.Write("IsIsolado(): vertice1{" + grafo.GetVertice(0).GetDadoValor() + "}  ");
                //Console.WriteLine(grafo.IsIsolado(grafo.GetVertice(0)).ToString());

                //Console.Write("IsPendente(): vertice1{" + grafo.GetVertice(0).GetDadoValor() + "}  ");
                //Console.WriteLine(grafo.IsPendente(grafo.GetVertice(0)).ToString());

                //Console.Write("IsRegular(): ");
                //Console.WriteLine(grafo.IsRegular().ToString());

                //Console.Write("IsNulo(): ");
                //Console.WriteLine(grafo.IsNulo().ToString());

                //Console.Write("IsCompleto(): ");
                //Console.WriteLine(grafo.IsCompleto().ToString());

                //Console.Write("IsConexo(): ");
                //Console.WriteLine(grafo.IsConexo().ToString());

                //Console.Write("IsEuleriano(): ");
                //Console.WriteLine(grafo.IsEuleriano().ToString());

                //Console.Write("IsUnicursal(): ");
                //Console.WriteLine(grafo.IsUnicursal().ToString());

                //Console.WriteLine("GetComplementar()");
                //Console.WriteLine(grafo.GetComplementar().ToStringSimplesSemEspaco());

                //grafo.GetAGMKruskal(out builder);
                //Console.WriteLine("Kruskal: ");
                //Console.WriteLine(builder.ToString());

                builder.Clear();
               
                agm = (Grafo)grafo.GetAGMKruskal(out builder);

                Console.WriteLine("Prim: ");
                Console.WriteLine(builder.ToString());

                Console.WriteLine("\n¡rvore Geradora MÌnima:\n" + agm.ToString());
            }
            else if (Digrafo.IsFileADigrafo(arquivo))
            {
               Digrafo digrafo = new Digrafo(arquivo);

                Console.Write("GetGrauEntrada(): vertice1{" + digrafo.GetVertice(0).GetDadoValor() + "} ");
                Console.WriteLine(digrafo.GetGrauEntrada((VerticeDirigido) digrafo.GetVertice(0)));

                Console.Write("GetGrauSaida(): vertice1{" + digrafo.GetVertice(0).GetDadoValor() + "}  ");
                Console.WriteLine(digrafo.GetGrauSaida((VerticeDirigido)digrafo.GetVertice(0)));

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
