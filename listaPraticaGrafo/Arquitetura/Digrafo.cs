using System;
using listaPraticaGrafo.Arquitetura.Interfaces;
using listaPraticaGrafo.Arquitetura.Estrutura;

namespace listaPraticaGrafo
{
    /// <summary>
    /// Grafo direcionado
    /// </summary>
    public class Digrafo : Grafo, IDigrafo
    {
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
