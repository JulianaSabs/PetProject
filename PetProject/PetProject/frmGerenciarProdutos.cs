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
    public partial class frmGerenciarProdutos : Form
    {
        public frmGerenciarProdutos()
        {
            InitializeComponent();

            //adicionando items pelo construtor.
            
            cbbUnidade.Items.Add("Kg");
            cbbUnidade.Items.Add("g");
            cbbUnidade.Items.Add("Litro");
            cbbUnidade.Items.Add("ml");
            cbbUnidade.Items.Add("metro");
            cbbUnidade.Items.Add("cm");

        }

        private void frmGerenciarProdutos_Load(object sender, EventArgs e)
        {
           // frmPesquisar abrir = new frmPesquisar();
           // abrir
        }

        private void frmGerenciarProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //abrindo a janela pesquisar
            frmPesquisar abrir = new frmPesquisar();
            abrir.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
