using System;
using listaPraticaGrafo.Arquitetura.Interfaces;
using listaPraticaGrafo.Arquitetura.Estrutura;
using System.Collections.Generic;

namespace listaPraticaGrafo
{
    /// <summary>
    /// Grafo direcionado
    /// </summary>
    public class Digrafo : Grafo, IDigrafo
    {
        public Digrafo()
        {
            base.Init();
            base.vertices = new List<Vertice>();
        }

        public Digrafo(int numero_vertices)
        {
            for (int i = 0; i < numero_vertices; i++)
            {
                base.vertices = new List<Vertice>();
            }
        }

        public Digrafo(string[] arquivo)
        {
            base.vertices = new List<Vertice>();
            this.GerarGrafo(arquivo);
        }

        public Digrafo(List<Vertice> lstVertices)
        {
            this.ValidarVertices(lstVertices);
            base.Init();
            base.vertices = lstVertices;
            base.CalcularArestas();
        }

        /// <summary>
        /// Verifica se a lista de vértices possui instâncias da classe "VerticeDirigido",
        /// Lançando uma exceção caso haja algum que não seja
        /// </summary>
        /// <param name="vertice"></param>
        private void ValidarVertices(List<Vertice> vertice)
        {
            foreach (Vertice item in vertice)
            {
                if (vertice.GetType() != typeof(VerticeDirigido))
                {
                    throw new Exception("Objetos da lista de vértices não são instâncias da classe VerticeDirigido." +
                        " Talvez você queira criar um Grafo ao em vez de um Digrafo ?");
                }
            }
        }

        /// <summary>
        /// Recebe um vetor string no qual deve estar com os itens separados por ';',
        /// a primeira linha deve dizer a quantidade de vértices que o grafo terá,
        /// e as linhas seguintes devem estar no seguinte formado:
        /// 
        /// v1;v2;p;d
        /// 
        /// v1 e v2 = Vértices que compoem a aresta
        /// p = peso da aresta do grafo caso exista
        /// d = direção da aresta caso exista
        /// 
        /// </summary>
        /// <param name="arquivo"></param>
        public override void GerarGrafo(string[] arquivo)
        {
            if (arquivo == null)
            {
                throw new Exception("Arquivo não possui valor");
            }
            else if (arquivo[1].Split(';').Length != 4)
            {
                throw new Exception("Arquivo não está no formato adequado para gerar um grafo");
            }

            Dado conteudo;
            VerticeDirigido vertice, novoVertice;
            ArestaDirigida aresta;
            string[] lineSplit;

            for (int i = 1; i < arquivo.Length; i++)
            {
                try
                {
                    lineSplit = arquivo[i].Split(';');
                    conteudo = new Dado(int.Parse(lineSplit[0]));

                    if (this.Contem(conteudo)) vertice = (VerticeDirigido)this.GetVertice(conteudo);
                    else
                    {
                        vertice = new VerticeDirigido(new Dado(int.Parse(lineSplit[0])));
                        this.vertices.Add(vertice);
                    }

                    conteudo = new Dado(int.Parse(lineSplit[1]));

                    if (this.Contem(conteudo))
                    {
                        novoVertice = (VerticeDirigido)this.GetVertice(conteudo);
                        aresta = new ArestaDirigida(vertice, novoVertice, int.Parse(lineSplit[2]));
                    }
                    else
                    {
                        novoVertice = new VerticeDirigido(conteudo);
                        aresta = new ArestaDirigida(vertice, novoVertice, int.Parse(lineSplit[2]));
                        this.vertices.Add(novoVertice);
                    }

                    vertice.AddAresta(aresta);
                    novoVertice.AddAresta(aresta);
                }
                catch (Exception e)
                {
                    throw new Exception("Arquivo possui conteúdo inválido para leitura " + e.Message);
                }
            }
        }

        /// <summary>
        /// Informa quantas arestas, do vértice passado por parâmetro, 
        /// possuem como destino o próprio vértice
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public int GetGrauEntrada(VerticeDirigido v1)
        {
            return v1.GetGrauEntrada();
        }

        /// <summary>
        /// Informa quantas arestas, do vértice passado por parâmetro, 
        /// possuem como origem o próprio vértice
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public int GetGrauSaida(VerticeDirigido v1)
        {
            return v1.GetGrauSaida();
        }

        /// <summary>
        /// Verifica se no grafo, há algum vértice cuja aresta aponta para o próprio vértice
        /// </summary>
        /// <returns></returns>
        public bool HasCiclo()
        {
            foreach (VerticeDirigido vertice in base.vertices)
            {
                if (vertice.TemCiclos())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica se o arquivo está no formato para ser um grafo, 
        /// Se houver qualquer erro na verificação, é retornado false
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static bool IsFileADigrafo(string[] file)
        {
            try
            {
                return file[1].Split(';').Length == 4;
            }
            catch
            {
                return false;
            }
        }
    }
}
