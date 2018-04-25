using System;

namespace listaPraticaGrafo.estrutura
{
    public interface IDado : IEquatable<IDado>
    {
        /// <summary>
        /// Deve verificar se um IDado é igual à outro
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        new bool Equals(IDado other);

        /// <summary>
        /// Deve comparar dois IDados. Retornando -1 se o que foi passado por parâmetro
        /// for "menor" que o IDado local contém; 0 Se eles forem iguais e 1 se o IDado local 
        /// for maior que aquele passado por parâmetro
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        int CompareTo(IDado other);

        /// <summary>
        /// Deve retornar o valor que o dado contém
        /// </summary>
        /// <returns></returns>
        object GetValor();
    }
}
