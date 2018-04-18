using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPraticaGrafo.estrutura
{
    class ConteudoVertice : Dado
    {
        private int valor { get; }

        public ConteudoVertice(int valor)
        {
            this.valor = valor;
        }

        public int CompareTo(Dado other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Dado other)
        {
            throw new NotImplementedException();
        }
    }
}
