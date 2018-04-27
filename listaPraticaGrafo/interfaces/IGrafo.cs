using listaPraticaGrafo.estrutura;

namespace listaPraticaGrafo.interfaces
{
    /// <summary>
    /// Define a arquitetura para uma estrutura abstrata que representa 
    /// um conjunto de elementos denominados vértices e suas
    /// relações de interdependência(ou arestas)
    /// </summary>
    public interface IGrafo
    {
        /// <summary>
        /// Passando dois vértices como parâmetro, o método deve verificar se os dois vértices possuem
        /// conexão, ou seja, são adjacentes.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        bool IsAdjacente(Vertice v1, Vertice v2);

        /// <summary>
        /// O método deve contar e retornar o número de arestas no qual o vértice passado no parâmetro possui.
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        int GetGrau(Vertice v1);

        /// <summary>
        /// Deve retornar FALSE caso o vértice no parâmetro possua o número de arestas igual a 0,
        /// e TRUE caso contrário.
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        bool IsIsolado(Vertice v1);

        /// <summary>
        /// Deve retornar TRUE caso o grau do vértice seja 1, e FALSE caso contrário.
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        bool IsPendente(Vertice v1);

        /// <summary>
        /// Deve retornar TRUE caso o grau de cada vértice for igual e FALSE caso contrário.
        /// </summary>
        /// <returns></returns>
        bool IsRegular();

        /// <summary>
        /// Deve retornar TRUE caso os vértices do grafo não possuam arestas e FALSE caso contrário.
        /// </summary>
        /// <returns></returns>
        bool IsNulo();

        /// <summary>
        /// Deve retornar TRUE caso todos os vértices do grafo tenham ligação com todos os outros vértices
        /// e FALSE caso não possuem.
        /// </summary>
        /// <returns></returns>
        bool IsCompleto();

        /// <summary>
        /// Deve retornar TRUE caso um grafo G=(V, E) possua um caminho entre qualquer par de vértice.
        /// Se existir ao menos 1 par que não esteja ligado com o restante do grafo, este grafo se torna
        /// desconexo, logo deve ser retornado FALSE.
        /// </summary>
        /// <returns></returns>
        bool IsConexo();

        /// <summary>
        /// Deve retornar TRUE caso seja possivel percorer todo o grafo passando uma única vez por todos os vértices.
        /// Se não for possível, este grafo não é euleriano e deve ser retornado FALSE
        /// Começa em um vértice v de um grafo G.
        /// termina em outro vértice w de G
        /// passando pelo menos uma vez em cada vértice
        /// e exatamente uma única vez em cada aresta G
        /// </summary>
        /// <returns></returns>
        bool IsEuleriano();

        /// <summary>
        /// Deve retornar TRUE caso seja possível percorrer todos os vértices do grafo uma única vez, sem retornar 
        /// ao vértice inicial.
        /// </summary>
        /// <returns></returns>
        bool IsUnicursal();

        /// <summary>
        /// Deve retornar complemento ou inverso de um grafo. No qual o complemento de G é um grafo H nos mesmos vértices
        /// tais que dois vértices de H são adjacentes se e somente se eles não são adjacentes em G. Isso é para encontrar
        /// o complemento de um grafo, você preenche todas as arestas que faltavam para obter um grafo completo, e remove
        /// todas as arestas que já estavam lá. Não é o conjunto complementar do grafo; apenas as arestas são 
        /// complementadas.
        /// </summary>
        /// <returns></returns>
        Grafo GetComplementar();

        /// <summary>
        /// Esse método deve retornar, para um grafo conexo, a Árvore Geradora Mínima obtida por meio da aplicação
        /// do algoritmo de Prim. É impresso uma linha de saída contendo a ordem em que o algoritmo de Prim inseriu
        /// na AGM os vértices do grafo original, sendo que o vértice inicial corresponde ao vértice passado como
        /// parâmetro. Além disso, se tivermos duas arestas como o mesmo peso, escolha aquela cuja soma dos índices
        /// dos vértices seja menor. Se tivermos um novo empate, escolha aquela incidente ao vértice de menor índice.
        /// </summary>
        /// <param name="v1">Vértice</param>
        /// <returns></returns>
        IGrafo GetAGMPrim(Vertice v1);

        /// <summary>
        /// Esse método deve retornar, para um grafo conexo, sua Árvore Geradora Mínima obtida por meio da aplicação 
        /// do algoritmo de Kruskal. Nesse método, deve também ser impressa uma linha de saída contendo a origem em que
        /// o algoritmo de Kruskal inseriu na AGM os vértices do grafo original, sendo que o vértice inicial 
        /// correspondente ao vértice passado como parâmetro. Além disso, se tivermos duas arestas com o mesmo peso,
        /// escolha aquela cuja soma dos índices dos vértices seja menor. Se tivermos um novo empate, escolha aquela
        /// incidente ao vértice de menor índice.
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        IGrafo GetAGMKruskal(Vertice v1);

        /// <summary>
        /// 
        /// Esse vértice deve retornar, para um grafo conexo, seu número de cut-vértices.
        /// 
        /// <para>
        /// Cut-vértice: Vértice que desconecta um grafo separável (também chamado cut vertex ou ponto de articulação) 
        /// </para>
        /// 
        /// <para> TEOREMAS:</para>
        /// 
        /// Teorema 1: 
        /// A conectividade de aresta de um grafo G, λ(G), não pode exceder o grau do vértice de menor grau λ(G) ≤ grau 
        /// do vértice de menor grau. Se um grafo apresenta, pelo menos, um vértice de grau 1 então a conectividade de aresta 
        /// desse grafo é composta por apenas uma aresta
        ///
        /// <para>
        /// Teorema 2: A conectividade de vértice de um grafo G, K(G), não pode exceder a conectividade de aresta de G.
        /// Para todo grafo conexo G tem-se: K(G) ≤ λ(G) ≤ grau do vértice de menor grau.
        /// </para>
        /// 
        /// <para>CONECTIVIDADE</para>
        /// Seja δ(G) o menor grau de vértice em G
        /// Para todo grafo conexo G, tem-se: K(G) ≤ λ (G) ≤ δ(G)
        /// 
        /// A máxima conectividade de vértice de um grafo G com N vértices e E arestas (e >= n-1) é 2e/n
        /// </summary>
        /// <returns></returns>
        int GetCutVertices();

        /// <summary>
        /// Deve adicionar um vértice a lista de vértices do grafo
        /// </summary>
        /// <param name="v1"></param>
        void AddVertice(Vertice v1);

        /// <summary>
        /// Deve remover um vértice da lista vértices do grafo, bem como as arestas que os demais vértices
        /// possuem com o qual será removido.
        /// </summary>
        /// <param name="v1"></param>
        void RemoverVertice(Vertice v1);
    }
}
