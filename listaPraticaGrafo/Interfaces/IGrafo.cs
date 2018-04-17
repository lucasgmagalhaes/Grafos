using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPraticaGrafo.Interfaces
{
    interface IGrafo
    {
        bool IsAdjacente(Vertice v1, Vertice v2);
        int GetGrau(Vertice v1);
        bool IsIsolado(Vertice v1);
        bool IsPendente(Vertice v1);
        bool IsRegular();
        bool IsNulo();
        bool IsCompleto();
        bool IsConexo();
        bool IsEuleriano();
        bool IsUnicursal();
        IGrafo GetComplementar();
        IGrafo GetAGMPrim(Vertice v1);
        IGrafo GetAGMKruskal(Vertice v1);
        int GetCutVertices();
    }
}
