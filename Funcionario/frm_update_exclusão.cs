using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionario
{
    public partial class frm_update_exclusão : Form
    {
        public frm_update_exclusão()
        {
            InitializeComponent();
        }

        private void Pct_salvar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja salvar os dados alterados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Função de update.
            }
        }

        private void Pct_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair sem salvar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Pct_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir os dados deste funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Função para excluir no banco

                //Após exclusão, fechamento do form
                this.Close();
            }
        }
    }
}
