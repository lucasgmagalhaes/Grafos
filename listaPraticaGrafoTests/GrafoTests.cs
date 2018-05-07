using Microsoft.VisualStudio.TestTools.UnitTesting;
using listaPraticaGrafo.utils;
using listaPraticaGrafo.Arquitetura.Interfaces;
using listaPraticaGrafo.Arquitetura.Estrutura;
using System.Collections.Generic;

namespace listaPraticaGrafo.Tests
{
    [TestClass()]
    public class GrafoTests
    {
        private readonly Grafo grafo = new Grafo(FileArray.GRAFO1_NAO_DIRIGIDO);
        private readonly Digrafo digrafo = new Digrafo(FileArray.GRAFO01_DIRIGIDO);

        [TestMethod()]
        public void GerarGrafoTest()
        {
            string grafoString = this.grafo.ToString();
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
            Vertice vertice = new Vertice(new Dado(10));
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
            Vertice vertice = new Vertice(new Dado(10));
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
            Assert.IsTrue(this.grafo.IsConexo());
        }

        [TestMethod()]
        public void IsCompletoTest()
        {
            Assert.IsTrue(this.grafo.IsCompleto());
        }

        [TestMethod()]
        public void IsAdjacenteTest()
        {
            bool val = this.grafo.IsAdjacente(this.grafo.GetVertices()[0], this.grafo.GetVertices()[1]);
            Assert.IsTrue(val);
        }

        [TestMethod()]
        public void GetGrauTest()
        {
            List<Vertice> lista = this.grafo.GetVertices();
            Assert.AreEqual(2, this.grafo.GetGrau(lista[0]));
        }

        [TestMethod()]
        public void GetCutVerticesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetComplementarTest()
        {
            Assert.Fail(this.grafo.GetComplementar().ToString());
        }
    }
}