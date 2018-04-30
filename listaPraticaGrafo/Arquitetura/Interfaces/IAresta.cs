using listaPraticaGrafo.Arquitetura.Estrutura;
using System;
using System.Collections.Generic;

namespace listaPraticaGrafo.Arquitetura.Interfaces
{
    public interface IAresta : IEquatable<IAresta>
    {
        /// <summary>
        /// Verifica se uma aresta é igual a outra por meio dos seus vértices
        /// e peso
        /// </summary>
        /// <param name="aresta"></param>
        /// <returns></returns>
        new bool Equals(IAresta aresta);

        /// <summary>
        /// Retorna os vértices que constituem a aresta
        /// </summary>
        /// <returns></returns>
        List<Vertice> GetVertices();

        /// <summary>
        /// Retorna o peso da aresta
        /// </summary>
        /// <returns></returns>
        int GetPeso();

        /// <summary>
        /// Dado um vértice para comparação, retorna aquele que não é o passado por parâmetro.
        /// 
        /// <para>Tendo uma aresta dois vértices, A e B, passando A no parâmetro do método, este irá 
        /// retornar B, e vice versa.</para>
        /// </summary>
        /// <param name="vertice">vertice</param>
        /// <returns></returns>
        Vertice GetVerticeDiferente(Vertice vertice);
        /// <summary>
        /// Retorna se a busca/pesquisa já passou por esta aresta
        /// </summary>
        /// <returns></returns>
        bool FoiVisitado();

        /// <summary>
        /// Define se um a aresta ja foi visitada
        /// </summary>
        /// <param name="visita"></param>
        void SetVisitado(bool visita);
    }
}
