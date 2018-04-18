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

        public Vertice(Dado dados)
        {
            this.dado = dados;
        }

        public Vertice(Dado dado, List<Aresta> arestas)
        {
            this.dado = dado;
            this.arestas = arestas;
        }

        public void AddAresta(Aresta aresta)
        {
            this.arestas.Add(aresta);
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
               if(vertices[0] == this)
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
            foreach(Aresta arr in this.arestas)
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
    }
}
