using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionario
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void Tsr_cadastramento_Click(object sender, EventArgs e)
        {
            frm_cadastro cadastro = new frm_cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void Pct_deslogar_Click(object sender, EventArgs e)
        {
            DialogResult decisao = MessageBox.Show("Deseja sair da sessão?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decisao == DialogResult.Yes)
            try
            {
                Application.Restart();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao tentar dar restart na aplicação");
            }
        }

        private void Frm_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Tsr_consultas_Click(object sender, EventArgs e)
        {
            frm_consulta consulta = new frm_consulta();
            consulta.Show();
            this.Hide();
        }
    }
}
