using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtCadastroAeS
{
    public partial class Usuario : Form
    {
        bool tipoEdicao = false;
        int atual = 0;
        private void HabilitaEdicao()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtNivel.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void DesabilitaEdicao()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtNivel.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = true;
        }

        private void MostraDados()
        {
            txtCodigo.Text = Principal.usuarios[atual].codigo.ToString();
            txtNome.Text = Principal.usuarios[atual].nome;
            txtNivel.Text = Principal.usuarios[atual].nivel;
            txtLogin.Text = Principal.usuarios[atual].login;
            txtSenha.Text = Principal.usuarios[atual].senha;
        }

        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            MostraDados();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                MostraDados();
            }
            else MessageBox.Show("Início do Arquivo!");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (Principal.contUsuario < 10)
            {
                txtCodigo.Text = (Principal.contUsuario + 1).ToString();
                txtNome.Text = "";
                txtNivel.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                HabilitaEdicao();
                tipoEdicao = true;
            }
            else MessageBox.Show("Arquivo cheio!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Principal.contUsuario > 0)
            {
                HabilitaEdicao();
                tipoEdicao = false;
            }
            else MessageBox.Show("Arquivo vazio!");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipoEdicao)
            {
                Principal.usuarios[Principal.contUsuario].codigo = int.Parse(txtCodigo.Text);
                Principal.usuarios[Principal.contUsuario].nome = txtNome.Text;
                Principal.usuarios[Principal.contUsuario].nivel = txtNivel.Text;
                Principal.usuarios[Principal.contUsuario].login = txtLogin.Text;
                Principal.usuarios[Principal.contUsuario].senha = txtSenha.Text;
                atual = Principal.contUsuario++;
            }
            else
            {
                Principal.usuarios[atual].nome = txtNome.Text;
                Principal.usuarios[atual].nivel = txtNivel.Text;
                Principal.usuarios[atual].login = txtLogin.Text;
                Principal.usuarios[atual].senha = txtSenha.Text;
            }
            DesabilitaEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            MostraDados();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (atual < Principal.contUsuario - 1)
            {
                atual++;
                MostraDados();
            }
            else MessageBox.Show("Fim de arquivo!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Principal.contUsuario > 0)
            {
                Principal.usuarios[atual].nome = "";
                Principal.usuarios[atual].nivel = "";
                Principal.usuarios[atual].login = "";
                Principal.usuarios[atual].senha = "";
                MostraDados();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
