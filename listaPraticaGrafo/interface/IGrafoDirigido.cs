using listaPraticaGrafo.estrutura;

namespace listaPraticaGrafo.interfaces
{
    interface IGrafoDirigido : IGrafo
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
