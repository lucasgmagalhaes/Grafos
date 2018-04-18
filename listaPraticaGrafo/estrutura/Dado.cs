using System;

namespace listaPraticaGrafo.estrutura
{
    public interface Dado : IEquatable<Dado>
    {
        new bool Equals(Dado other);
        int CompareTo(Dado other);
    }
}
