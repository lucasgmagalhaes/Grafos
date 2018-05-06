using listaPraticaGrafo.Arquitetura.Interfaces;
using System.Collections.Generic;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    public abstract class ArestaBase
    {
        protected Vertice vertice1;
        protected Vertice vertice2;
        protected bool visitada; //visitada, usada para grafo euleriano
        protected int peso;

        public ArestaBase(Vertice v1, Vertice v2)
        {
            this.vertice1 = v1;
            this.vertice2 = v2;
            this.visitada = false;
        }

        public ArestaBase(Vertice v1, Vertice v2, int peso)
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
        /// É retornado null caso o vértice no parâmetro seja igual aos dois vértices da aresta
        /// ou seja, a aresta seja um loop para o vértice
        /// </summary>
        /// <param name="vertice">vertice</param>
        /// <returns></returns>
        public Vertice GetVerticeDiferente(VerticeBase vertice)
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
        public bool FoiVisitado()
        {
            return visitada;
        }

        public void SetVisitado(bool visita)
        {
            this.visitada = visita;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} ; Peso {2}", this.vertice1.GetDadoValor(), this.vertice2.GetDadoValor(),
                    this.peso);
        }

        /// <summary>
        /// Compara a igualdade entre duas arestas comparando seus vértices e pesos
        /// </summary>
        /// <param name="aresta"></param>
        /// <returns></returns>
        public bool Equals(IAresta aresta)
        {
            try
            {
                Aresta comparar = (Aresta)aresta;
                return ((comparar.getDadoVertice1.Equals(this.vertice1.GetDado()) || comparar.getDadoVertice1.Equals(this.vertice2.GetDado())) &&
                     (comparar.getDadoVertice2.Equals(this.vertice1.GetDado()) || comparar.getDadoVertice2.Equals(this.vertice2.GetDado())) &&
                    comparar.GetPeso().Equals(this.peso));
            }
            catch
            {
                return false;
            }
        }
    }
}
