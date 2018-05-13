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

        public Vertice Clonar()
        {
            Vertice retorno = new Vertice(new Dado((int)this.GetDadoValor()));
            retorno.AddArestas(this.ClonarArestas());
            return retorno;
        }

        public List<Aresta> ClonarArestas()
        {
            List<Aresta> clone = new List<Aresta>();
            foreach (Aresta aresta in this.arestas)
            {
                clone.Add(aresta.Clonar());
            }
            return clone;
        }

        public void RemoverAresta(Aresta aresta)
        {
            if (this.arestas.Contains(aresta)) this.arestas.Remove(aresta);
        }
    }
}
