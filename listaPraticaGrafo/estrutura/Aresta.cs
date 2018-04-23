using System;
using System.Collections.Generic;

namespace listaPraticaGrafo.estrutura
{
    public class Aresta
    {
        protected Vertice vertice1;
        protected Vertice vertice2;
        /// <summary>
        /// visitada, usada para grafo euleriano
        /// </summary>
        protected bool visitada;
        protected object peso;

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

        public object GetPeso()
        {
            return this.peso;
        }

        /// <summary>
        /// Dado um vértice para comparação, retorna aquela que não é o passado por parâmetro.
        /// 
        /// Tendo uma aresta dois vértices, A e B, passando A no parâmetro do método, este ira 
        /// retornar B, e vice versa.
        /// </summary>
        /// <param name="vertice">vertice</param>
        /// <returns></returns>
        public Vertice GetVerticeDiferente(Vertice vertice)
        {
            if(this.vertice1 == vertice)
            {
                return this.vertice2;
            }
            else if(this.vertice2 == vertice)
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
    }
}
