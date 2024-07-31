namespace PDV {
    partial class frmPrincipal {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionário = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuário = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFluxoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLançarVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradasSaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentosRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradasSaídasRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesaRel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.SystemColors.Info;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProduto,
            this.MenuMovimentacoes,
            this.MenuRelatorio,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(948, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFuncionário,
            this.MenuCliente,
            this.MenuUsuário,
            this.MenuCargos,
            this.MenuFornecedores});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(71, 20);
            this.MenuCadastro.Text = "Cadastros";
            // 
            // MenuFuncionário
            // 
            this.MenuFuncionário.Name = "MenuFuncionário";
            this.MenuFuncionário.Size = new System.Drawing.Size(180, 22);
            this.MenuFuncionário.Text = "Funcionários";
            this.MenuFuncionário.Click += new System.EventHandler(this.MenuFuncionário_Click);
            // 
            // MenuCliente
            // 
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(180, 22);
            this.MenuCliente.Text = "Clientes";
            // 
            // MenuUsuário
            // 
            this.MenuUsuário.Name = "MenuUsuário";
            this.MenuUsuário.Size = new System.Drawing.Size(180, 22);
            this.MenuUsuário.Text = "Usuários";
            // 
            // MenuCargos
            // 
            this.MenuCargos.Name = "MenuCargos";
            this.MenuCargos.Size = new System.Drawing.Size(180, 22);
            this.MenuCargos.Text = "Cargos";
            // 
            // MenuFornecedores
            // 
            this.MenuFornecedores.Name = "MenuFornecedores";
            this.MenuFornecedores.Size = new System.Drawing.Size(180, 22);
            this.MenuFornecedores.Text = "Fornecedores";
            // 
            // MenuProduto
            // 
            this.MenuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutos,
            this.MenuEstoque});
            this.MenuProduto.Name = "MenuProduto";
            this.MenuProduto.Size = new System.Drawing.Size(67, 20);
            this.MenuProduto.Text = "Produtos";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(122, 22);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(122, 22);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFluxoCaixa,
            this.MenuLançarVendas,
            this.MenuEntradasSaidas,
            this.MenuDespesas});
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(104, 20);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // MenuFluxoCaixa
            // 
            this.MenuFluxoCaixa.Name = "MenuFluxoCaixa";
            this.MenuFluxoCaixa.Size = new System.Drawing.Size(163, 22);
            this.MenuFluxoCaixa.Text = "Fluxo Caixa";
            // 
            // MenuLançarVendas
            // 
            this.MenuLançarVendas.Name = "MenuLançarVendas";
            this.MenuLançarVendas.Size = new System.Drawing.Size(163, 22);
            this.MenuLançarVendas.Text = "Lançar Vendas";
            // 
            // MenuEntradasSaidas
            // 
            this.MenuEntradasSaidas.Name = "MenuEntradasSaidas";
            this.MenuEntradasSaidas.Size = new System.Drawing.Size(163, 22);
            this.MenuEntradasSaidas.Text = "Entradas / Saídas";
            // 
            // MenuDespesas
            // 
            this.MenuDespesas.Name = "MenuDespesas";
            this.MenuDespesas.Size = new System.Drawing.Size(163, 22);
            this.MenuDespesas.Text = "Despesas";
            // 
            // MenuRelatorio
            // 
            this.MenuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutosRel,
            this.MenuVendasRel,
            this.MenuMovimentosRel,
            this.MenuEntradasSaídasRel,
            this.MenuDespesaRel});
            this.MenuRelatorio.Name = "MenuRelatorio";
            this.MenuRelatorio.Size = new System.Drawing.Size(66, 20);
            this.MenuRelatorio.Text = "Relatório";
            // 
            // MenuProdutosRel
            // 
            this.MenuProdutosRel.Name = "MenuProdutosRel";
            this.MenuProdutosRel.Size = new System.Drawing.Size(163, 22);
            this.MenuProdutosRel.Text = "Produtos";
            // 
            // MenuVendasRel
            // 
            this.MenuVendasRel.Name = "MenuVendasRel";
            this.MenuVendasRel.Size = new System.Drawing.Size(163, 22);
            this.MenuVendasRel.Text = "Vendas";
            // 
            // MenuMovimentosRel
            // 
            this.MenuMovimentosRel.Name = "MenuMovimentosRel";
            this.MenuMovimentosRel.Size = new System.Drawing.Size(163, 22);
            this.MenuMovimentosRel.Text = "Movimentos";
            // 
            // MenuEntradasSaídasRel
            // 
            this.MenuEntradasSaídasRel.Name = "MenuEntradasSaídasRel";
            this.MenuEntradasSaídasRel.Size = new System.Drawing.Size(163, 22);
            this.MenuEntradasSaídasRel.Text = "Entradas / Saídas";
            // 
            // MenuDespesaRel
            // 
            this.MenuDespesaRel.Name = "MenuDespesaRel";
            this.MenuDespesaRel.Size = new System.Drawing.Size(163, 22);
            this.MenuDespesaRel.Text = "Despesas";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // img03
            // 
            this.img03.Image = global::PDV.Properties.Resources.lancar_despesas;
            this.img03.Location = new System.Drawing.Point(552, 277);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(177, 132);
            this.img03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img03.TabIndex = 4;
            this.img03.TabStop = false;
            // 
            // img02
            // 
            this.img02.Image = global::PDV.Properties.Resources.Movimentacoes;
            this.img02.Location = new System.Drawing.Point(759, 80);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(177, 132);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img02.TabIndex = 3;
            this.img02.TabStop = false;
            // 
            // img04
            // 
            this.img04.Image = global::PDV.Properties.Resources.lancar_caixa;
            this.img04.Location = new System.Drawing.Point(759, 277);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(177, 132);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img04.TabIndex = 2;
            this.img04.TabStop = false;
            // 
            // img01
            // 
            this.img01.Image = global::PDV.Properties.Resources.pngegg;
            this.img01.Location = new System.Drawing.Point(552, 80);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(177, 132);
            this.img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 469);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorio;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionário;
        private System.Windows.Forms.ToolStripMenuItem MenuCliente;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuário;
        private System.Windows.Forms.ToolStripMenuItem MenuCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuFluxoCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuLançarVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradasSaidas;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuVendasRel;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentosRel;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradasSaídasRel;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesaRel;
    }
}

