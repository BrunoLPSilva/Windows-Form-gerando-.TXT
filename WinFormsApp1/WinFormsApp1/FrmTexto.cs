using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmTexto : Form
    {
        public FrmTexto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();

        }

        private void SalvarArquivo()
        {
            File.WriteAllText(@"c:\arquivos\texto_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".txt", txtTexto.Text);
            MessageBox.Show("Arquivo aberto e salvo");
            txtTexto.Text = String.Empty;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo();

        }
    }
}

