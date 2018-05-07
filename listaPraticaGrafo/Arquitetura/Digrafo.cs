using System;
using listaPraticaGrafo.Arquitetura.Interfaces;
using listaPraticaGrafo.Arquitetura.Estrutura;
using System.Collections.Generic;

namespace listaPraticaGrafo
{
    /// <summary>
    /// Grafo direcionado
    /// </summary>
    public class Digrafo : Grafo, IDigrafo
    {
        public Digrafo()
        {
            base.Init();
            base.vertices = new List<Vertice>();
        }

        public Digrafo(int numero_vertices)
        {
            for (int i = 0; i < numero_vertices; i++)
            {
                base.vertices = new List<Vertice>();
            }
        }

        public Digrafo(string[] arquivo)
        {
            base.vertices = new List<Vertice>();
            base.GerarGrafo(arquivo);
        }

        public Digrafo(List<Vertice> lstVertices)
        {
            this.ValidarVertices(lstVertices);
            base.Init();
            base.vertices = lstVertices;
            base.CalcularArestas();
        }

        /// <summary>
        /// Verifica se a lista de vértices possui instâncias da classe "VerticeDirigido",
        /// Lançando uma exceção caso haja algum que não seja
        /// </summary>
        /// <param name="vertice"></param>
        private void ValidarVertices(List<Vertice> vertice)
        {
            foreach(Vertice item in vertice)
            {
                if(vertice.GetType() != typeof(VerticeDirigido))
                {
                    throw new Exception("Objetos da lista de vértices não são instâncias da classe VerticeDirigido."+
                        " Talvez você queira criar um Grafo ao em vez de um Digrafo ?");
                }
            }
        }

        /// <summary>
        /// Informa quantas arestas, do vértice passado por parâmetro, 
        /// possuem como destino o próprio vértice
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public int GetGrauEntrada(VerticeDirigido v1)
        {
            return v1.GetGrauEntrada();
        }

        /// <summary>
        /// Informa quantas arestas, do vértice passado por parâmetro, 
        /// possuem como origem o próprio vértice
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public int GetGrauSaida(VerticeDirigido v1)
        {
            return v1.GetGrauSaida();
        }

        /// <summary>
        /// Verifica se no grafo, há algum vértice cuja aresta aponta para o próprio vértice
        /// </summary>
        /// <returns></returns>
        public bool HasCiclo()
        {
            foreach(VerticeDirigido vertice in base.vertices)
            {
                if (vertice.TemCiclos())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
