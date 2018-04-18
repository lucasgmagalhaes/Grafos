using System.Collections.Generic; 
using listaPraticaGrafo.interfaces;
using listaPraticaGrafo.estrutura;

namespace listaPraticaGrafo
{
    public class Grafo : IGrafo
    {
        List<Aresta> lstAresta;

        public Grafo()
        {
            lstAresta = new List<Aresta>();

        }

        public IGrafo GetAGMKruskal(Vertice v1)
        {
            throw new System.NotImplementedException();
        }

        public IGrafo GetAGMPrim(Vertice v1)
        {
            throw new System.NotImplementedException();
        }

        public IGrafo GetComplementar()
        {
            throw new System.NotImplementedException();
        }

        public int GetCutVertices()
        {
            throw new System.NotImplementedException();
        }

        public int GetGrau(Vertice v1)
        {
            throw new System.NotImplementedException();
        }

        public bool IsAdjacente(Vertice v1, Vertice v2)
        {
            throw new System.NotImplementedException();
        }

        public bool IsCompleto()
        {
            throw new System.NotImplementedException();
        }

        public bool IsConexo()
        {
            throw new System.NotImplementedException();
        }

        public bool IsEuleriano()
        {
            throw new System.NotImplementedException();
        }

        public bool IsIsolado(Vertice v1)
        {
            throw new System.NotImplementedException();
        }

        public bool IsNulo()
        {
            throw new System.NotImplementedException();
        }

        public bool IsPendente(Vertice v1)
        {
            throw new System.NotImplementedException();
        }

        public bool IsRegular()
        {
            throw new System.NotImplementedException();
        }

        public bool IsUnicursal()
        {
            throw new System.NotImplementedException();
        }
    }
}
