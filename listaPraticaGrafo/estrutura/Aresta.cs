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
            List<Vertice> listaRetorno = new List<Vertice>();
            listaRetorno.Add(this.vertice1);
            listaRetorno.Add(this.vertice2);
            return listaRetorno;
        }

        public object GetPeso()
        {
            return this.peso;
        }
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
