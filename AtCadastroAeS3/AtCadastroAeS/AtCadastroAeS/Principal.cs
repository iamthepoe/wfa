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
    public partial class Principal : Form
    {
        public struct Usuar{
            public int codigo;
            public string nome;
            public string nivel;
            public string login;
            public string senha;
        }

        static public Usuar[] usuarios = new Usuar[10];
        static public int contUsuario = 0;

        public struct CadasC{
            public int codigo;
            public string nome;
            public string cpf;
            public string rg;
            public string end;
            public string bairro;
            public string cidade;
            public string uf;
            public string telefone;
            public string email;
            public string cep;
        }

        static public CadasC[] cadastro = new CadasC[10];
        static public int contCadastro= 0;

        public struct CadasP{
            public int codigo;
            public string desc;
            public string uni;
            public string qtd;
            public string pcC;
            public string pcV;
        }

        static public CadasP[] cadastrop = new CadasP[10];
        static public int contCadastrop = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            Usuario fu = new Usuario();
            fu.ShowDialog();
        }

        private void cliente_Click(object sender, EventArgs e)
        {
            CadastroC lol = new CadastroC();
            lol.ShowDialog();
        }

        private void produtos_Click(object sender, EventArgs e)
        {
            CadastroP lmao = new CadastroP();
            lmao.ShowDialog();
        }
    }
}
