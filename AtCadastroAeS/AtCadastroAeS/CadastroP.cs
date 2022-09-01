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
    public partial class CadastroP : Form
    {

        bool tipoEdicao = false;
        int atual = 0;
        private void HabilitaEdicao()
        {
            txtCodigo.Enabled = false;
            txtDesc.Enabled = true;
            txtUni.Enabled = true;
            txtQtd.Enabled = true;
            txtPC.Enabled = true;
            txtPV.Enabled = true;
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
            txtDesc.Enabled = false;
            txtUni.Enabled = false;
            txtQtd.Enabled = false;
            txtPC.Enabled = false;
            txtPV.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        private void MostraDados()
        {
            txtCodigo.Text = Principal.cadastrop[atual].codigo.ToString();
            txtDesc.Text = Principal.cadastrop[atual].desc;
            txtUni.Text = Principal.cadastrop[atual].uni;
            txtQtd.Text = Principal.cadastrop[atual].qtd;
            txtPC.Text = Principal.cadastrop[atual].pcC;
            txtPV.Text = Principal.cadastrop[atual].pcV;
        }
        public CadastroP()
        {
            InitializeComponent();
        }
        private void CadastroP_Load(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            MostraDados();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                MostraDados();
            }
            else MessageBox.Show("Início do arquivo!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            if (Principal.contUsuario < 10)
            {
                txtCodigo.Text = (Principal.contUsuario + 1).ToString();
                txtDesc.Text = "";
                txtUni.Text = "";
                txtQtd.Text = "";
                txtPC.Text = "";
                txtPV.Text = "";
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
                Principal.cadastrop[Principal.contCadastrop].codigo = int.Parse(txtCodigo.Text);
                Principal.cadastrop[Principal.contCadastrop].desc = txtDesc.Text;
                Principal.cadastrop[Principal.contCadastrop].uni = txtUni.Text;
                Principal.cadastrop[Principal.contCadastrop].qtd = txtQtd.Text;
                Principal.cadastrop[Principal.contCadastrop].pcC = txtPC.Text;
                Principal.cadastrop[Principal.contCadastrop].pcV = txtPV.Text;
                atual = Principal.contCadastrop++;
            }
            else
            {
                Principal.cadastrop[Principal.contCadastrop].desc = txtDesc.Text;
                Principal.cadastrop[Principal.contCadastrop].uni = txtUni.Text;
                Principal.cadastrop[Principal.contCadastrop].qtd = txtQtd.Text;
                Principal.cadastrop[Principal.contCadastrop].pcC = txtPC.Text;
                Principal.cadastrop[Principal.contCadastrop].pcV = txtPV.Text;
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
            if (Principal.contCadastrop > 0)
            {
                Principal.cadastrop[atual].desc = "";
                Principal.cadastrop[atual].uni = "";
                Principal.cadastrop[atual].qtd = "";
                Principal.cadastrop[atual].pcC = "";
                Principal.cadastrop[atual].pcV = "";
                MostraDados();
            }

        }
    }
}
