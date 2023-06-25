using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoMyPets
{
    public partial class frmPesquisar : Form
    {
        public string nome = "senac";


        public frmPesquisar()
        {
            InitializeComponent();
            txtDescricao.Enabled = false;
            lstPesquisar.Enabled = false;
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbCodigo.TabStop = false;
            rdbNome.TabStop = false;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                txtDescricao.Enabled = true;
                txtDescricao.Focus();
                MessageBox.Show("Código selecionado: " + txtDescricao.Text);
            }
            else if (rdbNome.Checked)
            {
                txtDescricao.Enabled = true;
                txtDescricao.Focus();
            }
            else
            {
                MessageBox.Show("Favor selecionar por código ou nome!!!");
            }


        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            realizarFoco();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            realizarFoco();
        }

        public void realizarFoco()
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Enabled = false;
            lstPesquisar.Enabled = false;
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbCodigo.TabStop = false;
            rdbNome.TabStop = false;
            txtDescricao.TabStop = false;
            txtDescricao.Clear();
            lstPesquisar.Items.Clear();
            btnPesquisar.Focus();
        }

        private void frmPesquisar_FormClosing(object sender, FormClosingEventArgs e)
        {
            // e.Cancel = true;
        }
    }
}