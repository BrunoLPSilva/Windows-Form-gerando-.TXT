using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }

        private void frmShow_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Iniciando o Formulario pelo construtor!"); 
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
