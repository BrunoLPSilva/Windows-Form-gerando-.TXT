using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormsApp1;

namespace WinFormsApp1
{


    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(" Iniciando o Formulario pelo construtor!");
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = " Olá PEDRO você é fuboca - " + ((Estado)cboEstados.SelectedItem).id;
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text;
            form.Show();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboEstados.Items.Clear();
            cboEstados.DataSource = Estado.Lista();
            cboEstados.Text = "[Selecione]";

            dataGridView.DataSource = Estado.Lista();

            // foreach(Estado estado in Estado.Lista())
            // {
            // cboEstados.Items.Add(estado);            }

            // cboEstados.Items.Add()

            //Maneira Complexa 
            /*
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Nome";

            var rows = new List<string[]>();
            foreach (Estado estado in Estado.Lista())
            {
                string[] row1 = new string[] { estado.id.ToString(), estado.Nome };
                rows.Add(row1);
            }

            foreach ( string[] rowArray in rows)
            {
                dataGridView.Rows.Add(rowArray);
            }
            */

            // Metodo Eficaz  ( SEMELHANTE A BANCO DE DADOS )
            var data = from estado in Estado.Lista()
                      // where estado.id == 1 || estado.id == 2
                       orderby estado.Nome
                       select new
                       {
                           id = estado.id,
                           Nome = estado.Nome
                       };

            dataGridView.DataSource = data.ToList();
        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTexto().Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }

}