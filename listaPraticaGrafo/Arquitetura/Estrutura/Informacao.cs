using System;
using listaPraticaGrafo.Arquitetura.Interfaces;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    /// <summary>
    /// Representa o valor que o vértice possui
    /// </summary>
    public class Informacao : IDado
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
            try
            {
                Informacao comparador = (Informacao)other;
                return ((int)comparador.GetValor() == this.valor);
            }
            catch
            {
                return false;
            }
        }
        public object GetValor()
        {
            return this.valor;
        }
    }
}
