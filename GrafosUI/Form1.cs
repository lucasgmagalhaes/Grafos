using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrafosUI
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openfile;
        private DialogResult resultFile;

        public Form1()
        {
            InitializeComponent();
            openfile = new OpenFileDialog();
        }

        private void btnselectfile_Click_1(object sender, EventArgs e)
        {
            this.resultFile = this.openfile.ShowDialog();

            if (this.resultFile == DialogResult.OK)
            {
                txtfilepath.Text = this.openfile.SafeFileName;
            }
        }
    }
}
