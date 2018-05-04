using listaPraticaGrafo.Arquitetura.Interfaces;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    /// <summary>
    /// Representa o valor que o vértice possui
    /// </summary>
    public class Dado : IDado
    {
        private int valor;

        public Dado(int valor)
        {
            this.valor = valor;
        }

        public int CompareTo(IDado other)
        {
            Dado comparador = (Dado)other;
            int valor = (int)other.GetValor();

            if (valor < this.valor) return -1;
            else if (valor > this.valor) return 1;
            else return 0;
        }

        public bool Equals(IDado other)
        {
            try
            {
                Dado comparador = (Dado)other;
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
