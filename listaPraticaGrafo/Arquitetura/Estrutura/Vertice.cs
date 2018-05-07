using System.Collections.Generic;
using listaPraticaGrafo.Arquitetura.Interfaces;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    public class Vertice : VerticeBase
    {
        public Vertice(IDado dados) : base(dados) { }

        public Vertice(IDado dado, List<Aresta> arestas) : base(dado, arestas)
        {
            this.arestas = new List<ArestaBase>();
            this.arestas.AddRange(arestas);
        }

        /// <summary>
        /// Número de arestas que o vértice possui
        /// </summary>
        /// <returns></returns>
        public int GetGrau()
        {
            return base.arestas.Count;
        }
    }
}
