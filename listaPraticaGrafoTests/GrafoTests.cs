using Microsoft.VisualStudio.TestTools.UnitTesting;
using listaPraticaGrafo.utils;
using listaPraticaGrafo.Arquitetura.Estrutura;

namespace listaPraticaGrafo.Tests
{
    [TestClass()]
    public class GrafoTests
    {
        private readonly Grafo grafo = new Grafo(FileArray.GRAFO1_NAO_DIRIGIDO);

        [TestMethod()]
        public void GerarGrafoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetVerticeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAGMPrimTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsUnicursalTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsRegularTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsPendenteTest()
        {
            Vertice vertice = new Vertice(new Informacao(10));
            Assert.IsFalse(this.grafo.IsPendente(vertice));
        }

        [TestMethod()]
        public void IsNuloTest()
        {
            Assert.IsFalse(this.grafo.IsNulo());
        }

        [TestMethod()]
        public void IsIsoladoTest()
        {
            Vertice vertice = new Vertice(new Informacao(10));
            Assert.IsTrue(this.grafo.IsIsolado(vertice));
        }

        [TestMethod()]
        public void IsEulerianoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsConexoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsCompletoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsAdjacenteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetGrauTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCutVerticesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetComplementarTest()
        {
            Assert.Fail();
        }
    }
}