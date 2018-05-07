using listaPraticaGrafo.Arquitetura.Interfaces;
using System;
using System.Collections.Generic;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    public class VerticeDirigido : Vertice, IVerticeDirigido
    {
        public VerticeDirigido(IDado dado) : base(dado)
        {
            this.dado = dado;
            this.arestas = new List<ArestaBase>();
            this.arestas.AddRange(arestas);
            this.visitado = false;
        }
        public VerticeDirigido(IDado dado, List<Aresta> arestas) : base(dado, arestas)
        {
            this.ValidarArestas(arestas);
            this.dado = dado;
            this.arestas = new List<ArestaBase>();
            this.arestas.AddRange(arestas);
            this.visitado = false;
        }

        /// <summary>
        /// Verifica se a lista de arestas possui objetos cujas instâncias são 
        /// da classe Arestadirida
        /// </summary>
        /// <param name="arestas"></param>
        private void ValidarArestas(List<Aresta> arestas)
        {
            foreach (Aresta item in arestas)
            {
                if (item.GetType() != typeof(ArestaDirigida))
                {
                    throw new Exception("Nem todos os itens da lista são instâncias da classe ArestaDirigida");
                }
            }
        }

        /// <summary>
        /// Informa qunatas arestas chegam neste vértice
        /// </summary>
        /// <returns></returns>
        public int GetGrauEntrada()
        {
            int count = 0;
            foreach (ArestaDirigida aresta in base.arestas)
            {
                if (aresta.GetDestino().Equals(this))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Informa quantas arestas saem deste vértice
        /// </summary>
        /// <returns></returns>
        public int GetGrauSaida()
        {
            int count = 0;
            foreach (ArestaDirigida aresta in base.arestas)
            {
                if (aresta.getOrigem().Equals(this))
                {
                    count++;
                }
            }
            return count;
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
                if (vertices[0] == this) return -1;
                else return 1;
            }
            return null;
        }
    }
}

