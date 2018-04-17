using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPraticaGrafo
{
    class Vertice
    {
        private Dados dados;
        private List<Aresta> arestas;

        public Dados getDados { get { return this.dados; } }
        public int getGrau { get { return this.arestas.Count(); } }

        public Vertice(Dados dados)
        {
            this.dados = dados;
        }

        public Vertice(Dados dados, List<Aresta> arestas)
        {
            this.dados = dados;
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
