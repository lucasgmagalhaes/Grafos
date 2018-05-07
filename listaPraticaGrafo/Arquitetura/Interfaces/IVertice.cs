using System;
using listaPraticaGrafo.Arquitetura.Enum;
using listaPraticaGrafo.Arquitetura.Estrutura;
using System.Collections.Generic;

namespace listaPraticaGrafo.Arquitetura.Interfaces
{
    public interface IVertice : ICloneable, IEquatable<IVertice>
    {
        /// <summary>
        /// Cria uma nova instância idêntica a do objeto
        /// </summary>
        /// <returns></returns>
        new object Clone();

        /// <summary>
        /// Verifica se um Vértice é igual ao outro por meio do dado que ele 
        /// armazena
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        new bool Equals(IVertice vertice);
        /// <summary>
        /// Insere uma nova aresta na lista de arestas do vértice
        /// </summary>
        /// <param name="aresta"></param>
        void AddAresta(ArestaBase aresta);
        /// <summary>
        /// Remove todas as arestas do vértice
        /// </summary>
        void LimpaArestas();

        /// <summary>
        /// Retorna a informção contida no vértice
        /// </summary>
        /// <returns></returns>
        IDado GetDado();

        /// <summary>
        /// Retorna a lista de todas as arestas do vértice
        /// </summary>
        /// <returns></returns>
        List<Aresta> GetArestas();

        /// <summary>
        /// ?????????????????????????????
        /// </summary>
        /// <returns></returns>
        VerticeBase GetVerticeChefe();

        /// <summary>
        /// Verifica se o vértice já foi visitado
        /// </summary>
        /// <returns></returns>
        bool FoiVisitado();

        /// <summary>
        /// Retorna o valor que o dado armazena
        /// </summary>
        /// <returns></returns>
        object GetDadoValor();

        /// <summary>
        /// Define se o vértice foi ou não visitado
        /// </summary>
        /// <param name="visita"></param>
        void SetVisitado(bool visita);

        /// <summary>
        /// Define a cor do vértice baseado na cor atual. Se ela for BRANCA, passará a ser CINZA,
        /// e se for CINZA, será PRETA.
        /// </summary>
        void AtualizarCor();

        /// <summary>
        /// Torna a cor do vértice, PRETO
        /// </summary>
        void FinalizaPercurso();

        /// <summary>
        /// Restaura a cor do vértice para a cor padrão dele, ou seja, BRANCO.
        /// </summary>
        void ResetarCor();

        /// <summary>
        /// Define a cor para este vértice
        /// <para>BRANCO - CINZA - PRETO</para>
        /// </summary>
        /// <param name="cor"></param>
        void SetCor(Cor cor);

        /// <summary>
        /// Retorna todos os vértices adjacetes ao vértice
        /// </summary>
        /// <returns></returns>
        List<Vertice> GetAdjacentes();

        /// <summary>
        /// Verifica se um vértice é adjacente(possui aresta) com outro vértice
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        bool IsAdjacente(VerticeBase vertice);

        ArestaBase GetMenorArestaNaoVisitada();
    }
}
