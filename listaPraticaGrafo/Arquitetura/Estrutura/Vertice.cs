using listaPraticaGrafo.Arquitetura.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using listaPraticaGrafo.Arquitetura.Interfaces;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    public class Vertice : IVertice
    {
        private List<Aresta> arestas;
        private IDado dado;
        /// <summary>
        /// Usado para realizar os métodos de pesquisa
        /// </summary>
        private Cor cor;
        protected bool visitado;

        public Cor Cor { get { return this.cor; } }

        public Vertice(IDado dados)
        {
            this.dado = dados;
            this.visitado = false;
            this.arestas = new List<Aresta>();
        }

        public Vertice(IDado dado, List<Aresta> arestas)
        {
            this.dado = dado;
            this.arestas = arestas;
            this.visitado = false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Insere uma nova aresta na lista de arestas do vértice.
        /// Não permite a inserção de arestas repetidas
        /// </summary>
        /// <param name="aresta"></param>
        public void AddAresta(Aresta aresta)
        {
            if (!this.Contem(aresta))
            {
                this.arestas.Add(aresta);
                List<Vertice> lstAux = aresta.GetVertices();
                Vertice vAux = lstAux.Last();
            }
        }
        public void LimpaArestas()
        {
            this.arestas = new List<Aresta>();
        }

        public int GetGrau()
        {
            return this.arestas.Count();
        }

        public IDado GetDado()
        {
            return this.dado;
        }

        /// <summary>
        /// Retorna a direção em que uma aresta aponta
        /// </summary>
        /// <param name="aresta"></param>
        /// <returns></returns>
        public object GetDirecao(Aresta aresta)
        {
            if (this.arestas.Contains(aresta))
            {
                List<Vertice> vertices = aresta.GetVertices();
                if (vertices[0] == this)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return this.dado.GetValor().ToString();
        }

        /// <summary>
        /// Fornece a lista de todos os vértices que fazem ligação(possuem aresta) com
        /// </summary>
        /// <returns></returns>
        public List<Vertice> GetAdjacentes()
        {
            List<Vertice> listaRetorno = new List<Vertice>();
            foreach (Aresta aresta in this.arestas)
            {
                listaRetorno.Add(aresta.GetVerticeDiferente(this));
            }
            return listaRetorno;
        }

        public string ToStringComArestas()
        {
            StringBuilder retorno = new StringBuilder();
            this.arestas.ForEach(delegate (Aresta aresta) { retorno.AppendLine(aresta.ToString()); });
            return retorno.ToString();
        }

        public List<Aresta> GetArestas()
        {
            return this.arestas;
        }

        public Vertice GetVerticeChefe()
        {
            return this;
        }
        public bool FoiVisitado()
        {
            return this.visitado;
        }

        public object GetDadoValor()
        {
            return this.dado.GetValor();
        }
        public void SetVisitado(bool visita)
        {
            this.visitado = visita;
        }

        /// <summary>
        /// Define a cor do vértice baseado na cor atual. Se ela for BRANCA, passará a ser CINZA,
        /// e se for CINZA, será PRETA.
        /// </summary>
        public void AtualizarCor()
        {
            if (this.cor == Cor.BRANCO)
            {
                this.cor = Cor.CINZA;
            }
            else if (this.cor == Cor.CINZA)
            {
                this.cor = Cor.PRETO;
            }
        }

        /// <summary>
        /// Torna a cor do vértice, PRETO
        /// </summary>
        public void FinalizaPercurso()
        {
            this.cor = Cor.PRETO;
        }

        /// <summary>
        /// Restaura a cor do vértice para a cor padrão dele, ou seja, BRANCO.
        /// </summary>
        public void ResetarCor()
        {
            this.cor = Cor.BRANCO;
        }

        public void SetCor(Cor cor)
        {
            this.cor = cor;
        }

        /// <summary>
        /// Faz a busca da aresta de menor peso do vertice
        /// </summary>
        /// <returns>Retorna aresta de menor peso</returns>
        public Aresta GetMenorAresta()
        {
            Aresta aMenor = null;
            foreach (Aresta aItem in this.arestas)
            {
                if (aMenor == null || aItem.GetPeso() < aMenor.GetPeso()) //acha a aresta de menor valor do vertice
                {
                    aMenor = aItem;
                }
            }
            return aMenor;
        }

        /// <summary>
        /// Faz a busca da aresta de menor peso do vertice e que 
        /// não foi visitada
        /// </summary>
        /// <returns>Retorna aresta de menor peso</returns>
        public Aresta GetMenorArestaNaoVisitada()
        {
            Aresta aMenor = null;
            foreach (Aresta aItem in this.arestas)
            {
                if (!aItem.FoiVisitado())
                {
                    if (aMenor == null || aItem.GetPeso() < aMenor.GetPeso())
                    {
                        aMenor = aItem;
                    }
                }
            }
            return aMenor;
        }

        /// <summary>
        /// Verifica se o vértice atual possui adjacência com outro vértice
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        public bool isAdjacenteDe(Vertice vertice)
        {
            List<Vertice> adjacentes = this.GetAdjacentes();
            foreach (Vertice v in adjacentes)
            {
                if (v.GetDadoValor().Equals(vertice.GetDadoValor()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica se o vértice já possui uma aresta igual aquela passada por parâmetro
        /// </summary>
        /// <param name="aresta"></param>
        /// <returns></returns>
        public bool Contem(Aresta aresta)
        {
            foreach (Aresta aresta1 in this.arestas)
            {
                if (aresta1.Equals(aresta))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica a igualdade entre dois vértices através do dado que eles armazenam
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        public bool Equals(IVertice vertice)
        {
            return (vertice.GetDado().Equals(this.dado));
        }
    }
}
