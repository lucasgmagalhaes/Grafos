using listaPraticaGrafo.Arquitetura.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using listaPraticaGrafo.Arquitetura.Interfaces;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    public class Vertice : VerticeBase
    {
        public Vertice(IDado dados)
            : base(dados)
        {
            this.dado = dados;
            this.visitado = false;
            this.arestas = new List<ArestaBase>();
        }

        public Vertice(IDado dado, List<Aresta> arestas)
            : base(dado, arestas)
        {
            this.dado = dado;
            this.arestas = new List<ArestaBase>();
            this.arestas.AddRange(arestas);
            this.visitado = false;
        }
    }
}
