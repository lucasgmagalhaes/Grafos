using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaPraticaGrafo.estrutura
{
    public class Vertice
    {
        private List<Aresta> arestas;
        private Dado dado;
        /// <summary>
        /// vChefe - Usado para kruskal e para definir se tem ciclo
        /// </summary>
        protected Vertice vChefe; 
        protected bool visitado;

        public Vertice(Dado dados)
        {
            this.dado = dados;
            this.vChefe = this;
            this.visitado = false;
        }

        public Vertice(Dado dado, List<Aresta> arestas)
        {
            this.dado = dado;
            this.arestas = arestas;
            this.vChefe = this;
            this.visitado = false;
        }

        public void AddAresta(Aresta aresta)
        {
            this.arestas.Add(aresta);
            List<Vertice> lstAux = aresta.GetVertices();
            Vertice vAux = lstAux.Last();
            vAux.vChefe = this;
        }

        public int GetGrau()
        {
            return this.arestas.Count();
        }

        public Dado GetDado()
        {
            return this.dado;
        }

        /// <summary>
        /// Retorna a direção em que uma aresta aponta
        /// </summary>
        /// <param name="aresta"></param>
        /// <returns></returns>
        public object GetDirecao(Aresta aresta)
        {
            if (this.arestas.Contains(aresta))
            {
                List<Vertice> vertices = aresta.GetVertices();
                if (vertices[0] == this)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder(this.dado.ToString());
            foreach (Aresta arr in this.arestas)
            {

                retorno.Append(arr.GetVertices()[0].GetDado() + ";" + arr.GetVertices()[1].GetDado()
                    + ";" + this.GetDirecao(arr) + ";" + arr.GetPeso());
            }
            return retorno.ToString();
        }

        public List<Aresta> GetArestas()
        {
            return this.arestas;
        }

        public Vertice GetVerticeChefe()
        {
            return this.vChefe;
        }
         public bool GetVisitado()
        {
            return this.visitado;
        }
        public void SetVisitado(bool visita)
        {
              this.visitado = visita;
        }
    }
}
