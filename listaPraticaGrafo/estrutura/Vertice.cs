using listaPraticaGrafo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace listaPraticaGrafo.estrutura
{
    public class Vertice : ICloneable
    {
        private List<Aresta> arestas;
        private IDado dado;
        /// <summary>
        /// Usado para realizar os métodos de pesquisa
        /// </summary>
        private Cor cor;
        /// <summary>
        /// vChefe - Usado para kruskal e para definir se tem ciclo
        /// </summary>
        protected Vertice vChefe; 
        protected bool visitado;

        public Vertice(IDado dados)
        {
            this.dado = dados;
            this.vChefe = this;
            this.visitado = false;
            this.arestas = new List<Aresta>();
        }

        public Vertice(IDado dado, List<Aresta> arestas)
        {
            this.dado = dado;
            this.arestas = arestas;
            this.vChefe = this;
            this.visitado = false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void AddAresta(Aresta aresta)
        {
            this.arestas.Add(aresta);
            List<Vertice> lstAux = aresta.GetVertices();
            Vertice vAux = lstAux.Last();
            vAux.vChefe = this;
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
            return this.vChefe;
        }
         public bool GetVisitado()
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

        public Cor GetCor()
        {
            return this.cor;
        }

        public void SetCor(Cor cor)
        {
            this.cor = cor;
        }
    }
}
