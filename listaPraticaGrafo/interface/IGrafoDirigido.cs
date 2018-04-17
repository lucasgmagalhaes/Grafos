using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPraticaGrafos.interfaces
{
    interface IGrafoDirigido
    {
        int GetGrauEntrada(Vertice v1);
        int GetGrauSaida(Vertice v1);
        bool HasCiclo();
    }
}
