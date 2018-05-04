using listaPraticaGrafo.Arquitetura.Interfaces;
using System;
using System.Collections.Generic;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    public class VerticeDirigido : Vertice, IVerticeDirigido
    {
        public VerticeDirigido(IDado dado) : base(dado)
        {
            base.dado = dado;
            base.arestas = new List<ArestaDirigida>();
        }

        public int GetGrauEntrada()
        {
            throw new NotImplementedException();
        }

        public int GetGrauSaida()
        {
            throw new NotImplementedException();
        }
    }
}
