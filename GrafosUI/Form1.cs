using listaPraticaGrafo;
using listaPraticaGrafo.Arquitetura.Estrutura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GrafosUI
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openfile;
        private Grafo grafo;
        private Digrafo digrafo;

        private Vertice v1;
        private Vertice v2;
        private VerticeDirigido vd1;
        private VerticeDirigido vd2;

        public Form1()
        {
            InitializeComponent();
            openfile = new OpenFileDialog();
        }

        private void btnselectfile_Click_1(object sender, EventArgs e)
        {
            if (this.openfile.ShowDialog() == DialogResult.OK)
            {
                txtfilepath.Text = this.openfile.SafeFileName;
            }
        }

        private void DefinirValorBooleano(Label label, bool resultado)
        {
            if (resultado)
            {
                label.Text = "True";
                label.ForeColor = Color.White;
                label.BackColor = Color.Green;
            }
            else
            {
                label.Text = "True";
                label.ForeColor = Color.White;
                label.BackColor = Color.Red;
            }
        }

        private void DefinirValor(Label label, string valor)
        {
            label.Text = valor;
        }

        private void CarregarValoresComboBox()
        {
            string[] valores = this.grafo.GetValoresVertices();
            this.cmbGetGrau.Items.AddRange(valores);
            this.cmbIsAdjacente1.Items.AddRange(valores);
            this.cmbIsAdjacente2.Items.AddRange(valores);
            this.cmbIsIsolado.Items.AddRange(valores);
            this.cmbIsPendente.Items.AddRange(valores);
        }

        private void btnExibirResultados_Click(object sender, EventArgs e)
        {
            if(this.openfile.SafeFileName != null)
            {
                LeitorArquivo leitor = new LeitorArquivo();
                string[] arquivo = leitor.lerArquivo(this.openfile.FileName);
                this.textArquivo.Text = arquivo.ToString();

                if (Grafo.IsFileAGrafo(arquivo))
                {
                    this.grafo = new Grafo(arquivo);

                    this.CarregarValoresComboBox();

                    this.DefinirValorBooleano(this.lblIsNulo, this.grafo.IsNulo());
                    this.DefinirValorBooleano(this.lblIsRegular, this.grafo.IsRegular());
                    this.DefinirValorBooleano(this.lblIsConexo, this.grafo.IsConexo());
                    this.DefinirValorBooleano(this.lblIsEuleriano, this.grafo.IsEuleriano());
                    this.DefinirValorBooleano(this.lblIsUnicursal, this.grafo.IsUnicursal());

                    this.ExibirComplementar();
                    this.ExibirKruskal();
                    this.ExibirPrim();
                }
                else if (Digrafo.IsFileADigrafo(arquivo))
                {
                    this.digrafo = new Digrafo(arquivo);
                    this.DefinirValorBooleano(this.lblIsNuloDigrafo, this.grafo.IsNulo());
                }
            }
        }

        private void ExibirKruskal()
        {
            StringBuilder valor = new StringBuilder();
            this.grafo.GetAGMKruskal(out valor);
            this.textKruskal.Text = valor.ToString();
        }

        private void ExibirComplementar()
        {
            StringBuilder valor = new StringBuilder();
            Grafo grafo = this.grafo.GetComplementar();
            this.textKruskal.Text = grafo.ToString();
        }

        private void ExibirPrim()
        {
            StringBuilder valor = new StringBuilder();
            this.grafo.GetAGMPrim(out valor);
            this.textKruskal.Text = valor.ToString();
        }

        private void btnIsAdjacente_Click(object sender, EventArgs e)
        {
            this.v1 = this.grafo.GetVertice(this.cmbIsAdjacente1.SelectedText);
            this.v2 = this.grafo.GetVertice(this.cmbIsAdjacente2.SelectedText);

            if (this.v1 != null && this.v2 != null)
            {
                this.DefinirValorBooleano(this.lblIsAdjacente, this.grafo.IsAdjacente(this.v1, this.v2));
            }
        }

        private void btnIsIsolado_Click(object sender, EventArgs e)
        {
            this.v1 = this.grafo.GetVertice(this.cmbIsIsolado.SelectedText);
            if (this.v1 != null)
            {
                this.DefinirValorBooleano(this.lblIsIsolado, this.grafo.IsIsolado(v1));
            }
        }

        private void btnIsPendente_Click(object sender, EventArgs e)
        {
            this.v1 = this.grafo.GetVertice(this.cmbIsPendente.SelectedText);
            if (this.v1 != null)
            {
                this.DefinirValorBooleano(this.lblIsPendente, this.grafo.IsPendente(v1));
            }
        }

        private void btnGetGrau_Click(object sender, EventArgs e)
        {
            this.v1 = this.grafo.GetVertice(this.cmbGetGrau.SelectedText);
            if (this.v1 != null)
            {
                this.DefinirValor(this.lblGetGrau, this.grafo.GetGrau(v1).ToString());
            }
        }

        private void btnGetGrauEntrada_Click(object sender, EventArgs e)
        {
            this.vd1 = (VerticeDirigido)this.digrafo.GetVertice(this.cmbGetGrauEntrada.SelectedText);
            if (this.v1 != null)
            {
                this.DefinirValor(this.lblGetGrauEntrada, this.digrafo.GetGrauEntrada(vd1).ToString());
            }
        }

        private void btnGetGrauSaida_Click(object sender, EventArgs e)
        {
            this.vd1 = (VerticeDirigido)this.digrafo.GetVertice(this.cmbGetGrauSaida.SelectedText);
            if (this.v1 != null)
            {
                this.DefinirValor(this.lblGetGrauEntrada, this.digrafo.GetGrauSaida(vd1).ToString());
            }
        }
    }
}
