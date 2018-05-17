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
        private string itemSelecionado;

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
            label.Visible = true;

            if (resultado)
            {
                label.Text = "True";
                label.ForeColor = Color.White;
                label.BackColor = Color.Green;
            }
            else
            {
                label.Text = "False";
                label.ForeColor = Color.White;
                label.BackColor = Color.Red;
            }
        }

        private void DefinirValor(Label label, string valor)
        {
            label.Visible = true;
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
            this.cmbGetGrauEntrada.Items.AddRange(valores);
            this.cmbGetGrauSaida.Items.AddRange(valores);
        }

        private void LimparTela()
        {
            this.cmbGetGrau.Items.Clear();
            this.cmbIsAdjacente1.Items.Clear();
            this.cmbIsAdjacente2.Items.Clear();
            this.cmbIsIsolado.Items.Clear();
            this.cmbIsPendente.Items.Clear();
            this.cmbGetGrauEntrada.Items.Clear();
            this.cmbGetGrauSaida.Items.Clear();

            this.textArquivo.Clear();
            this.textComplementar.Clear();
            this.textPrim.Clear();
            this.textKruskal.Clear();
        }

        private void CarregarArquivoNoRichText(string[] arquivo)
        {
            foreach (string linha in arquivo) this.textArquivo.AppendText(linha + "\n");
        }

        private void btnExibirResultados_Click(object sender, EventArgs e)
        {
            if (this.openfile.SafeFileName != null && this.openfile.FileName != "")
            {
                this.LimparTela();
                LeitorArquivo leitor = new LeitorArquivo();
                string[] arquivo = leitor.lerArquivo(this.openfile.FileName);
                this.CarregarArquivoNoRichText(arquivo);

                if (Grafo.IsFileAGrafo(arquivo))
                {
                    ((Control)this.tabPageGrafo).Enabled = true;
                    ((Control)this.tabPageDigrafo).Enabled = false;

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
                    this.grafo = new Grafo(arquivo); //GAMBIARRA
                }
                else if (Digrafo.IsFileADigrafo(arquivo))
                {
                    ((Control)this.tabPageGrafo).Enabled = false;
                    ((Control)this.tabPageDigrafo).Enabled = true;

                    this.tabControl.SelectedTab = this.tabPageDigrafo;
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
            if (grafo.ToString() == "") this.textComplementar.Text = "Não possui complementar";
            else this.textComplementar.Text = grafo.ToString();
        }

        private void ExibirPrim()
        {
            StringBuilder valor = new StringBuilder();
            this.grafo.GetAGMPrim(out valor);
            this.textPrim.Text = valor.ToString();
        }

        private void btnIsAdjacente_Click(object sender, EventArgs e)
        {
            if (this.cmbIsAdjacente1.SelectedItem != null && this.cmbIsAdjacente2.SelectedItem != null)
            {
                this.v1 = this.grafo.GetVertice(this.cmbIsAdjacente1.SelectedItem.ToString());
                this.v2 = this.grafo.GetVertice(this.cmbIsAdjacente2.SelectedItem.ToString());
                this.DefinirValorBooleano(this.lblIsAdjacente, this.grafo.IsAdjacente(this.v1, this.v2));

            }
        }

        private void btnIsIsolado_Click(object sender, EventArgs e)
        {
            if (this.cmbIsIsolado.SelectedItem != null)
            {
                this.v1 = this.grafo.GetVertice(this.cmbIsIsolado.SelectedItem.ToString());
                this.DefinirValorBooleano(this.lblIsIsolado, this.grafo.IsIsolado(v1));
            }
        }

        private void btnIsPendente_Click(object sender, EventArgs e)
        {
            if (this.cmbIsPendente.SelectedItem != null)
            {
                this.v1 = this.grafo.GetVertice(this.cmbIsPendente.SelectedItem.ToString());
                this.DefinirValorBooleano(this.lblIsPendente, this.grafo.IsPendente(v1));
            }
        }

        private void btnGetGrau_Click(object sender, EventArgs e)
        {
            if (this.cmbGetGrau.SelectedItem != null)
            {
                this.v1 = this.grafo.GetVertice(this.cmbGetGrau.SelectedItem.ToString());
                this.DefinirValor(this.lblGetGrau, this.grafo.GetGrau(v1).ToString());
            }
        }

        private void btnGetGrauEntrada_Click(object sender, EventArgs e)
        {
            if (this.cmbGetGrauEntrada.SelectedItem != null)
            {
                this.vd1 = (VerticeDirigido)this.digrafo.GetVertice(this.cmbGetGrauEntrada.SelectedItem.ToString());
                this.DefinirValor(this.lblGetGrauEntrada, this.digrafo.GetGrauEntrada(vd1).ToString());
            }
        }

        private void btnGetGrauSaida_Click(object sender, EventArgs e)
        {
            if (this.cmbGetGrauSaida.SelectedItem != null)
            {
                this.vd1 = (VerticeDirigido)this.digrafo.GetVertice(this.cmbGetGrauSaida.SelectedItem.ToString());
                this.DefinirValor(this.lblGetGrauEntrada, this.digrafo.GetGrauSaida(vd1).ToString());
            }
        }
    }
}
