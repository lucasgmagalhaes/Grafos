using System;
using System.Collections.Generic;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    public class Aresta
    {
        protected Vertice vertice1;
        protected Vertice vertice2;
        /// <summary>
        /// visitada, usada para grafo euleriano
        /// </summary>
        protected bool visitada;
        protected int peso;

        public Vertice getVertice1 { get { return vertice1; } }
        public Vertice getVertice2 { get { return vertice2; } }

        public object getValorVertice1 { get { return vertice1.GetDadoValor(); } }
        public object getValorVertice2 { get { return vertice2.GetDadoValor(); } }

        public Aresta(Vertice v1, Vertice v2)
        {
            this.vertice1 = v1;
            this.vertice2 = v2;
            this.visitada = false;
        }

        public Aresta(Vertice v1, Vertice v2, int peso)
        {
            this.vertice1 = v1;
            this.vertice2 = v2;
            this.peso = peso;
            this.visitada = false;
        }

        /// <summary>
        /// Retorna os vértices que constituem a aresta
        /// </summary>
        /// <returns></returns>
        public List<Vertice> GetVertices()
        {
            return new List<Vertice> { this.vertice1, this.vertice2 };
        }

        public int GetPeso()
        {
            return this.peso;
        }

        /// <summary>
        /// Dado um vértice para comparação, retorna aquele que não é o passado por parâmetro.
        /// 
        /// <para>Tendo uma aresta dois vértices, A e B, passando A no parâmetro do método, este irá 
        /// retornar B, e vice versa.</para>
        /// </summary>
        /// <param name="vertice">vertice</param>
        /// <returns></returns>
        public Vertice GetVerticeDiferente(Vertice vertice)
        {
            if (this.vertice1 == vertice)
            {
                return this.vertice2;
            }
            else if (this.vertice2 == vertice)
            {
                return this.vertice1;
            }
            return null;
        }

        /// <summary>
        /// Retorna se a busca/pesquisa já passou por esta aresta
        /// </summary>
        /// <returns></returns>
        public bool GetVisitado()
        {
            return visitada;
        }

        public void SetVisitado(bool visita)
        {
            this.visitada = visita;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} ; Peso {2}", this.getValorVertice1, this.getValorVertice2,
                    this.GetPeso());
        }
    }
}
