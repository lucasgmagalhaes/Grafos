using listaPraticaGrafo.Arquitetura.Interfaces;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    class ArestaDirigida : Aresta, IArestaDirigida
    {
        public ArestaDirigida(Vertice origem, Vertice destino) : base(origem, destino)
        {
            base.vertice1 = origem;
            base.vertice2 = destino;
        }

        public ArestaDirigida(Vertice origem, Vertice destino, int peso) : base(origem, destino, peso)
        {
            base.vertice1 = origem;
            base.vertice2 = destino;
            base.peso = peso;
        }

        public Vertice getOrigem()
        {
            return this.vertice1;
        }

        public Vertice GetDestino()
        {
            return this.vertice2;
        }
    }
}
