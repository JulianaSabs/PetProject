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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrCarregando_Tick(object sender, EventArgs e)
        {

            if (pgbCarregando.Value < 100)
            {
                pgbCarregando.Value = pgbCarregando.Value + 10;
                lblPorcentagem.Text = pgbCarregando.Value.ToString() + "%";
            }
            if (pgbCarregando.Value == 100)
            {
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
                tmrCarregando.Stop();
                //tmrCarregando.Enabled = false;

            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
