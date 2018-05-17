namespace GrafosUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textArquivo = new System.Windows.Forms.RichTextBox();
            this.btnExibirResultados = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.btnselectfile = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGrafo = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textKruskal = new System.Windows.Forms.RichTextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.textPrim = new System.Windows.Forms.RichTextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lblGetGrau = new System.Windows.Forms.Label();
            this.btnGetGrau = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbGetGrau = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblIsPendente = new System.Windows.Forms.Label();
            this.btnIsPendente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbIsPendente = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblIsIsolado = new System.Windows.Forms.Label();
            this.btnIsIsolado = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbIsIsolado = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblIsAdjacente = new System.Windows.Forms.Label();
            this.btnIsAdjacente = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbIsAdjacente2 = new System.Windows.Forms.ComboBox();
            this.cmbIsAdjacente1 = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblIsUnicursal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblIsEuleriano = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblIsConexo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblIsRegular = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIsNulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageDigrafo = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.lblIsNuloDigrafo = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.lblGetGrauEntrada = new System.Windows.Forms.Label();
            this.btnGetGrauEntrada = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbGetGrauEntrada = new System.Windows.Forms.ComboBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.lblGetGrauSaida = new System.Windows.Forms.Label();
            this.btnGetGrauSaida = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbGetGrauSaida = new System.Windows.Forms.ComboBox();
            this.textComplementar = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGrafo.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageDigrafo.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textArquivo);
            this.groupBox1.Controls.Add(this.btnExibirResultados);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(11, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arquivo";
            // 
            // textArquivo
            // 
            this.textArquivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArquivo.Enabled = false;
            this.textArquivo.Location = new System.Drawing.Point(637, 28);
            this.textArquivo.Name = "textArquivo";
            this.textArquivo.Size = new System.Drawing.Size(396, 120);
            this.textArquivo.TabIndex = 3;
            this.textArquivo.Text = "";
            // 
            // btnExibirResultados
            // 
            this.btnExibirResultados.Location = new System.Drawing.Point(229, 104);
            this.btnExibirResultados.Name = "btnExibirResultados";
            this.btnExibirResultados.Size = new System.Drawing.Size(274, 23);
            this.btnExibirResultados.TabIndex = 2;
            this.btnExibirResultados.Text = "Exibir Resultados";
            this.btnExibirResultados.UseVisualStyleBackColor = true;
            this.btnExibirResultados.Click += new System.EventHandler(this.btnExibirResultados_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtfilepath);
            this.groupBox2.Controls.Add(this.btnselectfile);
            this.groupBox2.Location = new System.Drawing.Point(141, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtfilepath
            // 
            this.txtfilepath.Enabled = false;
            this.txtfilepath.Location = new System.Drawing.Point(7, 29);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(380, 20);
            this.txtfilepath.TabIndex = 1;
            // 
            // btnselectfile
            // 
            this.btnselectfile.Location = new System.Drawing.Point(393, 27);
            this.btnselectfile.Name = "btnselectfile";
            this.btnselectfile.Size = new System.Drawing.Size(75, 23);
            this.btnselectfile.TabIndex = 0;
            this.btnselectfile.Text = "Arquivo";
            this.btnselectfile.UseVisualStyleBackColor = true;
            this.btnselectfile.Click += new System.EventHandler(this.btnselectfile_Click_1);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGrafo);
            this.tabControl.Controls.Add(this.tabPageDigrafo);
            this.tabControl.Location = new System.Drawing.Point(17, 226);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1043, 380);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageGrafo
            // 
            this.tabPageGrafo.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageGrafo.Controls.Add(this.groupBox15);
            this.tabPageGrafo.Controls.Add(this.groupBox14);
            this.tabPageGrafo.Controls.Add(this.groupBox13);
            this.tabPageGrafo.Controls.Add(this.groupBox12);
            this.tabPageGrafo.Controls.Add(this.groupBox4);
            this.tabPageGrafo.Controls.Add(this.groupBox11);
            this.tabPageGrafo.Controls.Add(this.groupBox10);
            this.tabPageGrafo.Controls.Add(this.groupBox9);
            this.tabPageGrafo.Controls.Add(this.groupBox8);
            this.tabPageGrafo.Controls.Add(this.groupBox7);
            this.tabPageGrafo.Controls.Add(this.groupBox6);
            this.tabPageGrafo.Controls.Add(this.groupBox3);
            this.tabPageGrafo.Location = new System.Drawing.Point(4, 22);
            this.tabPageGrafo.Name = "tabPageGrafo";
            this.tabPageGrafo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrafo.Size = new System.Drawing.Size(1035, 354);
            this.tabPageGrafo.TabIndex = 0;
            this.tabPageGrafo.Text = "Grafo não direcionado";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textKruskal);
            this.groupBox15.Location = new System.Drawing.Point(791, 6);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(235, 164);
            this.groupBox15.TabIndex = 11;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "AGMKruskal";
            // 
            // textKruskal
            // 
            this.textKruskal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textKruskal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textKruskal.Enabled = false;
            this.textKruskal.Location = new System.Drawing.Point(3, 16);
            this.textKruskal.Name = "textKruskal";
            this.textKruskal.Size = new System.Drawing.Size(229, 145);
            this.textKruskal.TabIndex = 5;
            this.textKruskal.Text = "";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.textPrim);
            this.groupBox14.Location = new System.Drawing.Point(550, 176);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(235, 164);
            this.groupBox14.TabIndex = 11;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "AGMPrim";
            // 
            // textPrim
            // 
            this.textPrim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPrim.Enabled = false;
            this.textPrim.Location = new System.Drawing.Point(3, 16);
            this.textPrim.Name = "textPrim";
            this.textPrim.Size = new System.Drawing.Size(229, 145);
            this.textPrim.TabIndex = 5;
            this.textPrim.Text = "";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textComplementar);
            this.groupBox13.Location = new System.Drawing.Point(550, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(235, 164);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Complementar";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lblGetGrau);
            this.groupBox12.Controls.Add(this.btnGetGrau);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Controls.Add(this.cmbGetGrau);
            this.groupBox12.Location = new System.Drawing.Point(189, 246);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(355, 64);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "GetGrau";
            // 
            // lblGetGrau
            // 
            this.lblGetGrau.AutoSize = true;
            this.lblGetGrau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetGrau.Location = new System.Drawing.Point(284, 28);
            this.lblGetGrau.Name = "lblGetGrau";
            this.lblGetGrau.Size = new System.Drawing.Size(13, 13);
            this.lblGetGrau.TabIndex = 2;
            this.lblGetGrau.Text = "0";
            this.lblGetGrau.Visible = false;
            // 
            // btnGetGrau
            // 
            this.btnGetGrau.Location = new System.Drawing.Point(172, 23);
            this.btnGetGrau.Name = "btnGetGrau";
            this.btnGetGrau.Size = new System.Drawing.Size(103, 23);
            this.btnGetGrau.TabIndex = 2;
            this.btnGetGrau.Text = "Verificar";
            this.btnGetGrau.UseVisualStyleBackColor = true;
            this.btnGetGrau.Click += new System.EventHandler(this.btnGetGrau_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(24, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Vértice 1";
            // 
            // cmbGetGrau
            // 
            this.cmbGetGrau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGetGrau.FormattingEnabled = true;
            this.cmbGetGrau.Location = new System.Drawing.Point(82, 24);
            this.cmbGetGrau.Name = "cmbGetGrau";
            this.cmbGetGrau.Size = new System.Drawing.Size(84, 21);
            this.cmbGetGrau.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblIsPendente);
            this.groupBox4.Controls.Add(this.btnIsPendente);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmbIsPendente);
            this.groupBox4.Location = new System.Drawing.Point(189, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 64);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IsPendente";
            // 
            // lblIsPendente
            // 
            this.lblIsPendente.AutoSize = true;
            this.lblIsPendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsPendente.Location = new System.Drawing.Point(284, 28);
            this.lblIsPendente.Name = "lblIsPendente";
            this.lblIsPendente.Size = new System.Drawing.Size(29, 13);
            this.lblIsPendente.TabIndex = 2;
            this.lblIsPendente.Text = "True";
            this.lblIsPendente.Visible = false;
            // 
            // btnIsPendente
            // 
            this.btnIsPendente.Location = new System.Drawing.Point(172, 23);
            this.btnIsPendente.Name = "btnIsPendente";
            this.btnIsPendente.Size = new System.Drawing.Size(103, 23);
            this.btnIsPendente.TabIndex = 2;
            this.btnIsPendente.Text = "Verificar";
            this.btnIsPendente.UseVisualStyleBackColor = true;
            this.btnIsPendente.Click += new System.EventHandler(this.btnIsPendente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vértice 1";
            // 
            // cmbIsPendente
            // 
            this.cmbIsPendente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsPendente.FormattingEnabled = true;
            this.cmbIsPendente.Location = new System.Drawing.Point(82, 24);
            this.cmbIsPendente.Name = "cmbIsPendente";
            this.cmbIsPendente.Size = new System.Drawing.Size(84, 21);
            this.cmbIsPendente.TabIndex = 3;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblIsIsolado);
            this.groupBox11.Controls.Add(this.btnIsIsolado);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.cmbIsIsolado);
            this.groupBox11.Location = new System.Drawing.Point(189, 106);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(355, 64);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "IsIsolado";
            // 
            // lblIsIsolado
            // 
            this.lblIsIsolado.AutoSize = true;
            this.lblIsIsolado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsIsolado.Location = new System.Drawing.Point(284, 28);
            this.lblIsIsolado.Name = "lblIsIsolado";
            this.lblIsIsolado.Size = new System.Drawing.Size(29, 13);
            this.lblIsIsolado.TabIndex = 2;
            this.lblIsIsolado.Text = "True";
            this.lblIsIsolado.Visible = false;
            // 
            // btnIsIsolado
            // 
            this.btnIsIsolado.Location = new System.Drawing.Point(172, 23);
            this.btnIsIsolado.Name = "btnIsIsolado";
            this.btnIsIsolado.Size = new System.Drawing.Size(103, 23);
            this.btnIsIsolado.TabIndex = 2;
            this.btnIsIsolado.Text = "Verificar";
            this.btnIsIsolado.UseVisualStyleBackColor = true;
            this.btnIsIsolado.Click += new System.EventHandler(this.btnIsIsolado_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(24, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Vértice 1";
            // 
            // cmbIsIsolado
            // 
            this.cmbIsIsolado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsIsolado.FormattingEnabled = true;
            this.cmbIsIsolado.Location = new System.Drawing.Point(82, 24);
            this.cmbIsIsolado.Name = "cmbIsIsolado";
            this.cmbIsIsolado.Size = new System.Drawing.Size(84, 21);
            this.cmbIsIsolado.TabIndex = 3;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblIsAdjacente);
            this.groupBox10.Controls.Add(this.btnIsAdjacente);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.cmbIsAdjacente2);
            this.groupBox10.Controls.Add(this.cmbIsAdjacente1);
            this.groupBox10.Location = new System.Drawing.Point(189, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(355, 94);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "IsAdjacente";
            // 
            // lblIsAdjacente
            // 
            this.lblIsAdjacente.AutoSize = true;
            this.lblIsAdjacente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAdjacente.Location = new System.Drawing.Point(284, 61);
            this.lblIsAdjacente.Name = "lblIsAdjacente";
            this.lblIsAdjacente.Size = new System.Drawing.Size(29, 13);
            this.lblIsAdjacente.TabIndex = 2;
            this.lblIsAdjacente.Text = "True";
            this.lblIsAdjacente.Visible = false;
            // 
            // btnIsAdjacente
            // 
            this.btnIsAdjacente.Location = new System.Drawing.Point(172, 56);
            this.btnIsAdjacente.Name = "btnIsAdjacente";
            this.btnIsAdjacente.Size = new System.Drawing.Size(103, 23);
            this.btnIsAdjacente.TabIndex = 2;
            this.btnIsAdjacente.Text = "Verificar";
            this.btnIsAdjacente.UseVisualStyleBackColor = true;
            this.btnIsAdjacente.Click += new System.EventHandler(this.btnIsAdjacente_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(177, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Vértice 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(27, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Vértice 1";
            // 
            // cmbIsAdjacente2
            // 
            this.cmbIsAdjacente2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsAdjacente2.FormattingEnabled = true;
            this.cmbIsAdjacente2.Location = new System.Drawing.Point(229, 26);
            this.cmbIsAdjacente2.Name = "cmbIsAdjacente2";
            this.cmbIsAdjacente2.Size = new System.Drawing.Size(84, 21);
            this.cmbIsAdjacente2.TabIndex = 4;
            // 
            // cmbIsAdjacente1
            // 
            this.cmbIsAdjacente1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsAdjacente1.FormattingEnabled = true;
            this.cmbIsAdjacente1.Location = new System.Drawing.Point(82, 26);
            this.cmbIsAdjacente1.Name = "cmbIsAdjacente1";
            this.cmbIsAdjacente1.Size = new System.Drawing.Size(84, 21);
            this.cmbIsAdjacente1.TabIndex = 3;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblIsUnicursal);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Location = new System.Drawing.Point(6, 206);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(163, 44);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            // 
            // lblIsUnicursal
            // 
            this.lblIsUnicursal.AutoSize = true;
            this.lblIsUnicursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsUnicursal.Location = new System.Drawing.Point(107, 16);
            this.lblIsUnicursal.Name = "lblIsUnicursal";
            this.lblIsUnicursal.Size = new System.Drawing.Size(29, 13);
            this.lblIsUnicursal.TabIndex = 1;
            this.lblIsUnicursal.Text = "True";
            this.lblIsUnicursal.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "IsUnicursal";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblIsEuleriano);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Location = new System.Drawing.Point(6, 156);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(163, 44);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            // 
            // lblIsEuleriano
            // 
            this.lblIsEuleriano.AutoSize = true;
            this.lblIsEuleriano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsEuleriano.Location = new System.Drawing.Point(107, 16);
            this.lblIsEuleriano.Name = "lblIsEuleriano";
            this.lblIsEuleriano.Size = new System.Drawing.Size(29, 13);
            this.lblIsEuleriano.TabIndex = 1;
            this.lblIsEuleriano.Text = "True";
            this.lblIsEuleriano.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "IsEuleriano";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblIsConexo);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Location = new System.Drawing.Point(6, 106);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 44);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            // 
            // lblIsConexo
            // 
            this.lblIsConexo.AutoSize = true;
            this.lblIsConexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsConexo.Location = new System.Drawing.Point(107, 16);
            this.lblIsConexo.Name = "lblIsConexo";
            this.lblIsConexo.Size = new System.Drawing.Size(29, 13);
            this.lblIsConexo.TabIndex = 1;
            this.lblIsConexo.Text = "True";
            this.lblIsConexo.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "IsConexo";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblIsRegular);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(6, 56);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(163, 44);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // lblIsRegular
            // 
            this.lblIsRegular.AutoSize = true;
            this.lblIsRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsRegular.Location = new System.Drawing.Point(107, 16);
            this.lblIsRegular.Name = "lblIsRegular";
            this.lblIsRegular.Size = new System.Drawing.Size(29, 13);
            this.lblIsRegular.TabIndex = 1;
            this.lblIsRegular.Text = "True";
            this.lblIsRegular.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "IsRegular";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblIsNulo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 44);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lblIsNulo
            // 
            this.lblIsNulo.AutoSize = true;
            this.lblIsNulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsNulo.Location = new System.Drawing.Point(107, 16);
            this.lblIsNulo.Name = "lblIsNulo";
            this.lblIsNulo.Size = new System.Drawing.Size(29, 13);
            this.lblIsNulo.TabIndex = 1;
            this.lblIsNulo.Text = "True";
            this.lblIsNulo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IsNulo";
            // 
            // tabPageDigrafo
            // 
            this.tabPageDigrafo.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDigrafo.Controls.Add(this.groupBox18);
            this.tabPageDigrafo.Location = new System.Drawing.Point(4, 22);
            this.tabPageDigrafo.Name = "tabPageDigrafo";
            this.tabPageDigrafo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDigrafo.Size = new System.Drawing.Size(1035, 354);
            this.tabPageDigrafo.TabIndex = 1;
            this.tabPageDigrafo.Text = "Digrafo";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.groupBox19);
            this.groupBox18.Controls.Add(this.groupBox16);
            this.groupBox18.Controls.Add(this.groupBox17);
            this.groupBox18.Location = new System.Drawing.Point(309, 19);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(404, 245);
            this.groupBox18.TabIndex = 12;
            this.groupBox18.TabStop = false;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.lblIsNuloDigrafo);
            this.groupBox19.Controls.Add(this.label31);
            this.groupBox19.Location = new System.Drawing.Point(18, 28);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(163, 44);
            this.groupBox19.TabIndex = 11;
            this.groupBox19.TabStop = false;
            // 
            // lblIsNuloDigrafo
            // 
            this.lblIsNuloDigrafo.AutoSize = true;
            this.lblIsNuloDigrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsNuloDigrafo.Location = new System.Drawing.Point(107, 16);
            this.lblIsNuloDigrafo.Name = "lblIsNuloDigrafo";
            this.lblIsNuloDigrafo.Size = new System.Drawing.Size(29, 13);
            this.lblIsNuloDigrafo.TabIndex = 1;
            this.lblIsNuloDigrafo.Text = "True";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(6, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "IsNulo";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.lblGetGrauEntrada);
            this.groupBox16.Controls.Add(this.btnGetGrauEntrada);
            this.groupBox16.Controls.Add(this.label25);
            this.groupBox16.Controls.Add(this.cmbGetGrauEntrada);
            this.groupBox16.Location = new System.Drawing.Point(18, 78);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(355, 64);
            this.groupBox16.TabIndex = 8;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "GrauEntrada";
            // 
            // lblGetGrauEntrada
            // 
            this.lblGetGrauEntrada.AutoSize = true;
            this.lblGetGrauEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetGrauEntrada.Location = new System.Drawing.Point(284, 28);
            this.lblGetGrauEntrada.Name = "lblGetGrauEntrada";
            this.lblGetGrauEntrada.Size = new System.Drawing.Size(29, 13);
            this.lblGetGrauEntrada.TabIndex = 2;
            this.lblGetGrauEntrada.Text = "True";
            // 
            // btnGetGrauEntrada
            // 
            this.btnGetGrauEntrada.Location = new System.Drawing.Point(172, 23);
            this.btnGetGrauEntrada.Name = "btnGetGrauEntrada";
            this.btnGetGrauEntrada.Size = new System.Drawing.Size(103, 23);
            this.btnGetGrauEntrada.TabIndex = 2;
            this.btnGetGrauEntrada.Text = "Verificar";
            this.btnGetGrauEntrada.UseVisualStyleBackColor = true;
            this.btnGetGrauEntrada.Click += new System.EventHandler(this.btnGetGrauEntrada_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(24, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Vértice 1";
            // 
            // cmbGetGrauEntrada
            // 
            this.cmbGetGrauEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGetGrauEntrada.FormattingEnabled = true;
            this.cmbGetGrauEntrada.Location = new System.Drawing.Point(82, 24);
            this.cmbGetGrauEntrada.Name = "cmbGetGrauEntrada";
            this.cmbGetGrauEntrada.Size = new System.Drawing.Size(84, 21);
            this.cmbGetGrauEntrada.TabIndex = 3;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.lblGetGrauSaida);
            this.groupBox17.Controls.Add(this.btnGetGrauSaida);
            this.groupBox17.Controls.Add(this.label27);
            this.groupBox17.Controls.Add(this.cmbGetGrauSaida);
            this.groupBox17.Location = new System.Drawing.Point(18, 148);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(355, 64);
            this.groupBox17.TabIndex = 9;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "GrauSaída";
            // 
            // lblGetGrauSaida
            // 
            this.lblGetGrauSaida.AutoSize = true;
            this.lblGetGrauSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetGrauSaida.Location = new System.Drawing.Point(284, 28);
            this.lblGetGrauSaida.Name = "lblGetGrauSaida";
            this.lblGetGrauSaida.Size = new System.Drawing.Size(29, 13);
            this.lblGetGrauSaida.TabIndex = 2;
            this.lblGetGrauSaida.Text = "True";
            // 
            // btnGetGrauSaida
            // 
            this.btnGetGrauSaida.Location = new System.Drawing.Point(172, 23);
            this.btnGetGrauSaida.Name = "btnGetGrauSaida";
            this.btnGetGrauSaida.Size = new System.Drawing.Size(103, 23);
            this.btnGetGrauSaida.TabIndex = 2;
            this.btnGetGrauSaida.Text = "Verificar";
            this.btnGetGrauSaida.UseVisualStyleBackColor = true;
            this.btnGetGrauSaida.Click += new System.EventHandler(this.btnGetGrauSaida_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(24, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Vértice 1";
            // 
            // cmbGetGrauSaida
            // 
            this.cmbGetGrauSaida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGetGrauSaida.FormattingEnabled = true;
            this.cmbGetGrauSaida.Location = new System.Drawing.Point(82, 24);
            this.cmbGetGrauSaida.Name = "cmbGetGrauSaida";
            this.cmbGetGrauSaida.Size = new System.Drawing.Size(84, 21);
            this.cmbGetGrauSaida.TabIndex = 3;
            // 
            // textComplementar
            // 
            this.textComplementar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textComplementar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textComplementar.Enabled = false;
            this.textComplementar.Location = new System.Drawing.Point(3, 16);
            this.textComplementar.Name = "textComplementar";
            this.textComplementar.Size = new System.Drawing.Size(229, 145);
            this.textComplementar.TabIndex = 6;
            this.textComplementar.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 613);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageGrafo.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageDigrafo.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textArquivo;
        private System.Windows.Forms.Button btnExibirResultados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.Button btnselectfile;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGrafo;
        private System.Windows.Forms.TabPage tabPageDigrafo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblIsNulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblIsConexo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblIsRegular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblIsEuleriano;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblIsUnicursal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblIsAdjacente;
        private System.Windows.Forms.Button btnIsAdjacente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbIsAdjacente2;
        private System.Windows.Forms.ComboBox cmbIsAdjacente1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lblIsIsolado;
        private System.Windows.Forms.Button btnIsIsolado;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbIsIsolado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblIsPendente;
        private System.Windows.Forms.Button btnIsPendente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbIsPendente;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label lblGetGrau;
        private System.Windows.Forms.Button btnGetGrau;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbGetGrau;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.RichTextBox textPrim;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RichTextBox textKruskal;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label lblGetGrauEntrada;
        private System.Windows.Forms.Button btnGetGrauEntrada;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbGetGrauEntrada;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label lblGetGrauSaida;
        private System.Windows.Forms.Button btnGetGrauSaida;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbGetGrauSaida;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label lblIsNuloDigrafo;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.RichTextBox textComplementar;
    }
}

