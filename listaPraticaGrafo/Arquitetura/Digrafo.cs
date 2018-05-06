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
            base.Init();
            base.vertices = lstVertices;
            base.CalcularArestas();
        }

        public int GetGrauEntrada(Vertice v1)
        {
            throw new NotImplementedException();
        }

        public int GetGrauSaida(Vertice v1)
        {
            throw new NotImplementedException();
        }

        public bool HasCiclo()
        {
            throw new NotImplementedException();
        }
    }
}
