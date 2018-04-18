using System.Collections.Generic;
using System.Linq;
namespace listaPraticaGrafo.estrutura
{
    public class Vertice
    {
        private List<Aresta> arestas;

        public Dado dado { get; }
        public int getGrau { get { return this.arestas.Count(); } }

        public Vertice(Dado dados)
        {
            this.dado = dados;
        }

        public Vertice(Dado dado, List<Aresta> arestas)
        {
            this.dado = dado;
            this.arestas = arestas;
        }

        public void AddAresta(Aresta aresta)
        {
            this.arestas.Add(aresta);
        }

        public Aresta AddArestaCom(Vertice vertice)
        {
            Aresta a = new Aresta(this, vertice);
            this.arestas.Add(a);
            return a;
        }
    }
}
