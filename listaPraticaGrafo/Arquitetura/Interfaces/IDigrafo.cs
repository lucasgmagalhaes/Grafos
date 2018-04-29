using listaPraticaGrafo.Arquitetura.Estrutura;

namespace listaPraticaGrafo.Arquitetura.Interfaces
{
    /// <summary>
    /// Define a arquitetura para uma estrutura abstrata que representa 
    /// um conjunto de elementos denominados vértices e suas
    /// relações de interdependência(ou arestas) na qual as arestas possuem
    /// direção.
    /// </summary>
    interface IDigrafo : IGrafo
    {
        /// <summary>
        /// Retorna o número de vértices que incidem ao vértice passado por parâmetro
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        int GetGrauEntrada(Vertice v1);

        /// <summary>
        /// Retorna o número de vértices que vértice passado por parâmetro incide
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        int GetGrauSaida(Vertice v1);

        /// <summary>
        /// Retorna TRUE caso o grafo possua vértices que possuam areas com eles mesmo
        /// </summary>
        /// <returns></returns>
        bool HasCiclo();
    }
}
