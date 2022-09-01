
namespace AtCadastroAeS
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuario2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cliente2 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtos2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.relatoriosToolStripMenuItem,
            this.sair});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuario,
            this.cliente,
            this.produtos});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Cadastros";
            // 
            // usuario
            // 
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(180, 22);
            this.usuario.Text = "Usuários";
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // cliente
            // 
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(180, 22);
            this.cliente.Text = "Clientes";
            this.cliente.Click += new System.EventHandler(this.cliente_Click);
            // 
            // produtos
            // 
            this.produtos.Name = "produtos";
            this.produtos.Size = new System.Drawing.Size(180, 22);
            this.produtos.Text = "Produtos";
            this.produtos.Click += new System.EventHandler(this.produtos_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuario2,
            this.cliente2,
            this.produtos2});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // usuario2
            // 
            this.usuario2.Name = "usuario2";
            this.usuario2.Size = new System.Drawing.Size(180, 22);
            this.usuario2.Text = "Usuários";
            // 
            // cliente2
            // 
            this.cliente2.Name = "cliente2";
            this.cliente2.Size = new System.Drawing.Size(180, 22);
            this.cliente2.Text = "Clientes";
            // 
            // produtos2
            // 
            this.produtos2.Name = "produtos2";
            this.produtos2.Size = new System.Drawing.Size(180, 22);
            this.produtos2.Text = "Produtos";
            // 
            // sair
            // 
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(38, 20);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clique nas funções acima \r\npara realizar o que deseja.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // Principal
            // 
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1187, 613);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Principal";
            this.Text = "Cadastro com Array e Struct";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuario;
        private System.Windows.Forms.ToolStripMenuItem cliente;
        private System.Windows.Forms.ToolStripMenuItem produtos;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuario2;
        private System.Windows.Forms.ToolStripMenuItem cliente2;
        private System.Windows.Forms.ToolStripMenuItem produtos2;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

