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

        public int GetGrauEntrada(VerticeDirigido v1)
        {
            return v1.GetGrauEntrada();
        }

        public int GetGrauSaida(VerticeDirigido v1)
        {
            return v1.GetGrauSaida();
        }

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
