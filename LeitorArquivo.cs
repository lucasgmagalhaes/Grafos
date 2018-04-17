using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ARVORE
{
    public class LeitorArquivo
    {/// <summary>
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
