namespace listaPraticaGrafo.estrutura
{
    public class Aresta
    {
        private Vertice vOrigem;
        private Vertice vDestino;

        public Aresta(Vertice v1, Vertice v2)
        {
            this.vOrigem = v1;
            this.vDestino = v2;
        }
    }
}
