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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Btn_logar_Click(object sender, EventArgs e)
        {
            //Logar. Apenas realizar o código das 3 linhas abaixo quando as credenciais de login forem confirmadas no banco.
            frm_principal principal = new frm_principal();
            this.Hide();
            principal.Show();
        }

        private void Txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.Clear();
                txt_username.ForeColor = System.Drawing.Color.Black;
            }
        }
        
        private void Txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.ForeColor = SystemColors.ButtonShadow;
                txt_username.Text = "Username";
            }
        }
        private void Txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Clear();
                txt_password.UseSystemPasswordChar = true;
                txt_password.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void Txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.ForeColor = SystemColors.ButtonShadow;
                txt_password.UseSystemPasswordChar = false;
                txt_password.Text = "Password";
            }
        }

        private void Txt_username_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_logar_Click(sender, e);
            }
        }

        private void Txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_logar_Click(sender, e);
            }
        }
    }
}
