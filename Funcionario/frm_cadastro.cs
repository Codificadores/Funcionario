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
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
        }
       
        private void Pct_sair_Click(object sender, EventArgs e)
        {
            //Voltar pro Menu Principal
            this.Close();
        }

        private void Pct_salvar_Click(object sender, EventArgs e)
        {
            //Função para salvar no banco de dados
            FuncionarioEntity funcionario = new FuncionarioEntity();
            funcionario.nome = txt_nome.Text;
            funcionario.sexo = cbo_sexo.Text;
            funcionario.nascimento = mtx_nascimento.Text;
            funcionario.rg = mtx_rg.Text;
            funcionario.cpf = mtx_cpf.Text;
            funcionario.cep = mtx_cep.Text;
            funcionario.logradouro = txt_logradouro.Text;
            funcionario.numeroCasa = txt_numeroCasa.Text;
            funcionario.bairro = txt_bairro.Text;
            funcionario.cidade = txt_cidade.Text;
            funcionario.estado = txt_estado.Text;
            funcionario.admissao = mtx_admissao.Text;
            funcionario.demissao = mtx_demissao.Text;
            funcionario.tipoContrato = cbo_tipoContrato.Text;
            funcionario.tempoContrato = int.Parse(txt_tempoContrato.Text);
            funcionario.email = txt_email.Text;
            funcionario.telFixo = txt_telFixo.Text;
            funcionario.celular = mtx_celular.Text;
            funcionario.cargo = cbo_cargo.Text;
            funcionario.departamento = cbo_departamento.Text;
            funcionario.salario = double.Parse(txt_salario.Text);
        }

        private void Frm_cadastro_Load(object sender, EventArgs e)
        {

        }

        private void Frm_cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_principal principal = new frm_principal();
            principal.Show();
        }
      
    }
}
