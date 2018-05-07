using listaPraticaGrafo.Arquitetura.Interfaces;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    public class ArestaDirigida : ArestaBase, IArestaDirigida
    {
        public ArestaDirigida(VerticeDirigido origem, VerticeDirigido destino) : base(origem, destino) { }

        public ArestaDirigida(VerticeDirigido origem, VerticeDirigido destino, int peso) : base(origem, destino, peso) { }

        /// <summary>
        /// Vértice de onde a aresta vem
        /// </summary>
        /// <returns></returns>
        public Vertice getOrigem()
        {
            return base.vertice1;
        }

        /// <summary>
        /// Vértice para onde a aresta aponta
        /// </summary>
        /// <returns></returns>
        public Vertice GetDestino()
        {
            return base.vertice2;
        }
    }
}
