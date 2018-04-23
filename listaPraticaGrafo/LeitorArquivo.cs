using listaPraticaGrafo.estrutura;
using System.IO;

namespace listaPraticaGrafo
{
    public class LeitorArquivo
    {
    /// <summary>
    /// Retorna vetor do arquivo lido, cada indice do vetor é uma linha do arquivo.
    /// </summary>
    /// <param name="caminho"></param>
    /// <returns></returns>
        public string[] leArquivo(string caminho)
        {
            string[] arquivoLido;
            if (File.Exists(caminho))
            {
                arquivoLido = File.ReadAllLines(caminho);
                return arquivoLido;
            }
            return null;
        }
    }
}
