using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMyPets
{
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            //txtFolha.Text = txtSalario.Text;
        }

        private void txtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFolha.Text = txtSalario.Text;
            }
        }

        private void chkPlanoSaude_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
    }
}
