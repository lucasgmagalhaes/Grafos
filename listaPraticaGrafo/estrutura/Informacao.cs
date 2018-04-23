using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPraticaGrafo.estrutura
{
    /// <summary>
    /// Representa o valor que o vértice possui
    /// </summary>
    class Informacao : IDado
    {
        private int valor;

        public Informacao(int valor)
        {
            this.valor = valor;
        }

        public int CompareTo(IDado other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(IDado other)
        {
            if (other.GetValor() is int)
            {
                return ((int)other.GetValor() == this.GetValor());
            }
            return false;
        }

        public int GetValor()
        {
            return this.valor;
        }

        object IDado.GetValor()
        {
            throw new NotImplementedException();
        }
    }
}
