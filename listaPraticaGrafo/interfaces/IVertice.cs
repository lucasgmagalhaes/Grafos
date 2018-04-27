using listaPraticaGrafo.Enum;
using listaPraticaGrafo.estrutura;
using System;
using System.Collections.Generic;

namespace listaPraticaGrafo.interfaces
{
    public interface IVertice : ICloneable
    {
        /// <summary>
        /// Cria uma nova instância idêntica a do objeto
        /// </summary>
        /// <returns></returns>
        new object Clone();

        /// <summary>
        /// Insere uma nova aresta na lista de arestas do vértice
        /// </summary>
        /// <param name="aresta"></param>
        void AddAresta(Aresta aresta);
        /// <summary>
        /// Remove todas as arestas do vértice
        /// </summary>
        void LimpaArestas();

        /// <summary>
        /// Informa o grau do vértice(Quantas arestas ele possui)
        /// </summary>
        /// <returns></returns>
        int GetGrau();

        /// <summary>
        /// Retorna a informção contida no vértice
        /// </summary>
        /// <returns></returns>
        IDado GetDado();

        /// <summary>
        /// Retorna a direção em que uma aresta aponta
        /// </summary>
        /// <param name="aresta"></param>
        /// <returns></returns>
        object GetDirecao(Aresta aresta);

        /// <summary>
        /// Retorna a lista de todas as arestas do vértice
        /// </summary>
        /// <returns></returns>
        List<Aresta> GetArestas();

        /// <summary>
        /// ?????????????????????????????
        /// </summary>
        /// <returns></returns>
        Vertice GetVerticeChefe();

        /// <summary>
        /// Verifica se o vértice já foi visitado
        /// </summary>
        /// <returns></returns>
        bool GetVisitado();

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
    }
}
