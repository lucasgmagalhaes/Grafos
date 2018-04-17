using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPraticaGrafo
{
    class Aresta
    {
        private Vertice vOrigem;
        private Vertice vDestino;

        public Aresta(Vertice v1, Vertice v2)
        {
            this.vOrigem = v1;
            this.vDestino = v2;
        }
    }
}
