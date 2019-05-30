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
    public partial class frm_consulta : Form
    {
        public frm_consulta()
        {
            InitializeComponent();
        }

        private void Cbo_filtro_TextChanged(object sender, EventArgs e)
        {
            switch (cbo_filtro.Text)
            {
                case "Nome":
                    txt_valor.ForeColor = SystemColors.ButtonShadow;
                    txt_valor.Text = "Insira o nome";
                    cbo_filtroValor.Enabled = false;
                    txt_valor.Enabled = true;
                    btn_consultar.Enabled = true;
                    break;
                case "CPF":
                    txt_valor.ForeColor = SystemColors.ButtonShadow;
                    txt_valor.Text = "Insira o código";
                    cbo_filtroValor.Enabled = false;
                    txt_valor.Enabled = true;
                    btn_consultar.Enabled = true;
                    break;
                case "Cargo":
                    txt_valor.Enabled = false;
                    cbo_filtroValor.Enabled = true;
                    btn_consultar.Enabled = true;
                    cbo_filtroValor.Items.Clear();
                    cbo_filtroValor.Items.Add("Cargo 1");
                    cbo_filtroValor.Items.Add("Cargo 2");
                    cbo_filtroValor.Items.Add("Cargo 3");
                    cbo_filtroValor.Items.Add("Cargo 4");
                    cbo_filtroValor.Items.Add("Cargo 5");
                    break;
                case "Departamento":
                    txt_valor.Enabled = false;
                    cbo_filtroValor.Enabled = true;
                    btn_consultar.Enabled = true;
                    cbo_filtroValor.Items.Clear();
                    cbo_filtroValor.Items.Add("Administrativo");
                    cbo_filtroValor.Items.Add("Financeiro");
                    cbo_filtroValor.Items.Add("Recursos Humanos");
                    cbo_filtroValor.Items.Add("Comercial");
                    cbo_filtroValor.Items.Add("Operacional");
                    break;
                case "Contrato":
                    txt_valor.Enabled = false;
                    cbo_filtroValor.Enabled = true;
                    btn_consultar.Enabled = true;
                    cbo_filtroValor.Items.Clear();
                    cbo_filtroValor.Items.Add("Tempo determinado");
                    cbo_filtroValor.Items.Add("Tempo indeterminado");
                    cbo_filtroValor.Items.Add("Temporário");
                    cbo_filtroValor.Items.Add("Eventual");
                    cbo_filtroValor.Items.Add("Autônomo");
                    cbo_filtroValor.Items.Add("Estágio");
                    break;
                default:
                    cbo_filtroValor.Items.Clear();
                    txt_valor.Enabled = false;
                    btn_consultar.Enabled = true;
                    break;
            }
        }

        private void Frm_consulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_principal principal = new frm_principal();
            principal.Show();
        }

        private void Txt_valor_Enter(object sender, EventArgs e)
        {
            if (txt_valor.Text == "Insira o nome" || txt_valor.Text == "Insira o código")
            {
                txt_valor.Text = "";
                txt_valor.ForeColor = Color.Black;
            }
        }

        private void Txt_valor_Leave(object sender, EventArgs e)
        {
            if (txt_valor.Text == "")
            {
                txt_valor.ForeColor = SystemColors.ButtonShadow;
                if (cbo_filtro.Text == "Nome")
                    txt_valor.Text = "Insira o nome";

                if (cbo_filtro.Text == "Código")
                    txt_valor.Text = "Insira o código";
                
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            //Abrir a tela de consulta.
        }

        private void Txt_codigo_Enter(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "Insira o CPF do funcionário")
            {
                txt_codigo.Text = "";
                txt_codigo.ForeColor = Color.Black;
            }
        }

        private void Txt_codigo_Leave(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                txt_codigo.Text = "Insira o CPF do funcionário";
                txt_codigo.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            //Abrir uma tela semelhante ao do Cadastro, porém com informações alteráveis.
            frm_update_exclusão updateExclusão = new frm_update_exclusão();//Temporário, apagar depois
            updateExclusão.Show(); //Temporário, apagar depois
        }

        private void Pct_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
