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

        public void RemoverAresta(Aresta aresta)
        {
            this.arestas.RemoveAll(aresta_local => aresta_local.Equals(aresta));
        }
        
        /// <summary>
        /// Para uma lista de vértices, verifica se o vértice passado no parâmetro existe nessa lista,
        /// comparando pelo valor do dado do vértice
        /// </summary>
        /// <param name="vertices"></param>
        /// <param name="vertice"></param>
        /// <returns></returns>
        public static bool Contem(List<Vertice> vertices, Vertice vertice)
        {
            foreach (Vertice vertice_index in vertices)
            {
                if (vertice.GetDadoValor().Equals(vertice_index.GetDadoValor()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Busca um vértice da lista caso ele exista nela
        /// </summary>
        /// <param name="vertice"></param>
        /// <param name="vertices"></param>
        /// <returns></returns>
        public static Vertice Get(Vertice vertice, List<Vertice> vertices)
        {
            foreach (Vertice vertice_index in vertices)
            {
                if (vertice.GetDadoValor() == vertice_index.GetDadoValor())
                {
                    return vertice_index;
                }
            }
            return null;
        }
    }
}
