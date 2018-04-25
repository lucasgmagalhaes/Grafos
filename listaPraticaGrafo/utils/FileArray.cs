namespace listaPraticaGrafo.utils
{
    /// <summary>
    /// Classe usada para testes de leitura de arquivo
    /// O sumário de cada variável representa o valor do arquivo
    /// </summary>
    public class FileArray
    {
        /// <summary>
        /// <para>3</para> 
        /// <para>1;2;4</para> 
        /// <para>2;3;10</para>
        /// </summary>
        public static string[] GRAFO1_NAO_DIRIGIDO = { "3", "1;2;4", "1;3;10" };

        /// <summary>
        /// <para>3</para>
        /// <para>1;2;4;1</para>
        /// <para>1;2;11;-1</para>
        /// <para>1;3;7;1</para>
        /// <para>2;3;10;-1</para>
        /// </summary>
        public static string[] GRAFO01_DIRIGIDO = { "3", "1;2;4;1", "1;2;11;-1", "1,3,7,1", "2,3,10,-1" };
    }
}
