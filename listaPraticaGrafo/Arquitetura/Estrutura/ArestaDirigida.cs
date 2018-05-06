using listaPraticaGrafo.Arquitetura.Interfaces;

namespace listaPraticaGrafo.Arquitetura.Estrutura
{
    public class ArestaDirigida : ArestaBase, IArestaDirigida
    {
        public ArestaDirigida(VerticeDirigido origem, VerticeDirigido destino) : base(origem, destino) { }

        public ArestaDirigida(VerticeDirigido origem, VerticeDirigido destino, int peso) : base(origem, destino, peso) { }

        public Vertice getOrigem()
        {
            return base.vertice1;
        }

        public Vertice GetDestino()
        {
            return base.vertice2;
        }
    }
}
