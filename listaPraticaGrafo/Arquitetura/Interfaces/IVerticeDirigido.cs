using listaPraticaGrafo.Arquitetura.Estrutura;

namespace listaPraticaGrafo.Arquitetura.Interfaces
{
    public interface IVerticeDirigido
    {
        int GetGrauEntrada();
        int GetGrauSaida();

        /// <summary>
        /// Retorna a direção em que uma aresta aponta
        /// </summary>
        /// <param name="aresta"></param>
        /// <returns></returns>
        object GetDirecao(Aresta aresta);
    }
}
