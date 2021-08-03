namespace GUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnContasAPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnContasAReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelContasAReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelContasAPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPermissaoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConsultaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtUsuarioLogado = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.mnUsuarios,
            this.ferramentasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnClientes,
            this.mnFornecedores,
            this.mnProdutos,
            this.testeToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // mnClientes
            // 
            this.mnClientes.Name = "mnClientes";
            this.mnClientes.Size = new System.Drawing.Size(235, 30);
            this.mnClientes.Text = "Clientes";
            // 
            // mnFornecedores
            // 
            this.mnFornecedores.Name = "mnFornecedores";
            this.mnFornecedores.Size = new System.Drawing.Size(235, 30);
            this.mnFornecedores.Text = "Fornecedores";
            // 
            // mnProdutos
            // 
            this.mnProdutos.Name = "mnProdutos";
            this.mnProdutos.Size = new System.Drawing.Size(235, 30);
            this.mnProdutos.Text = "Produtos";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.testeToolStripMenuItem.Text = "Teste";
            this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnConsultaCliente,
            this.mnConsultaFornecedor,
            this.mnConsultaProduto});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // mnConsultaCliente
            // 
            this.mnConsultaCliente.Name = "mnConsultaCliente";
            this.mnConsultaCliente.Size = new System.Drawing.Size(214, 30);
            this.mnConsultaCliente.Text = "Cliente";
            // 
            // mnConsultaFornecedor
            // 
            this.mnConsultaFornecedor.Name = "mnConsultaFornecedor";
            this.mnConsultaFornecedor.Size = new System.Drawing.Size(214, 30);
            this.mnConsultaFornecedor.Text = "Fornecedor";
            // 
            // mnConsultaProduto
            // 
            this.mnConsultaProduto.Name = "mnConsultaProduto";
            this.mnConsultaProduto.Size = new System.Drawing.Size(214, 30);
            this.mnConsultaProduto.Text = "Produto";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCompra,
            this.mnVenda,
            this.mnEstoque});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // mnCompra
            // 
            this.mnCompra.Name = "mnCompra";
            this.mnCompra.Size = new System.Drawing.Size(180, 30);
            this.mnCompra.Text = "Compra";
            // 
            // mnVenda
            // 
            this.mnVenda.Name = "mnVenda";
            this.mnVenda.Size = new System.Drawing.Size(180, 30);
            this.mnVenda.Text = "Venda";
            // 
            // mnEstoque
            // 
            this.mnEstoque.Name = "mnEstoque";
            this.mnEstoque.Size = new System.Drawing.Size(180, 30);
            this.mnEstoque.Text = "Estoque";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnContasAPagar,
            this.mnContasAReceber});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // mnContasAPagar
            // 
            this.mnContasAPagar.Name = "mnContasAPagar";
            this.mnContasAPagar.Size = new System.Drawing.Size(276, 30);
            this.mnContasAPagar.Text = "Contas a Pagar";
            // 
            // mnContasAReceber
            // 
            this.mnContasAReceber.Name = "mnContasAReceber";
            this.mnContasAReceber.Size = new System.Drawing.Size(276, 30);
            this.mnContasAReceber.Text = "Contas a Receber";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.financeirosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // financeirosToolStripMenuItem
            // 
            this.financeirosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnRelContasAReceber,
            this.mnRelContasAPagar});
            this.financeirosToolStripMenuItem.Name = "financeirosToolStripMenuItem";
            this.financeirosToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.financeirosToolStripMenuItem.Text = "Financeiros";
            // 
            // mnRelContasAReceber
            // 
            this.mnRelContasAReceber.Name = "mnRelContasAReceber";
            this.mnRelContasAReceber.Size = new System.Drawing.Size(419, 30);
            this.mnRelContasAReceber.Text = "Contas a Receber por Cliente";
            // 
            // mnRelContasAPagar
            // 
            this.mnRelContasAPagar.Name = "mnRelContasAPagar";
            this.mnRelContasAPagar.Size = new System.Drawing.Size(419, 30);
            this.mnRelContasAPagar.Text = "Contas a Pagar por Fornecedor";
            // 
            // mnUsuarios
            // 
            this.mnUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadUsuario,
            this.mnPermissaoUsuario,
            this.mnConsultaUsuario});
            this.mnUsuarios.Name = "mnUsuarios";
            this.mnUsuarios.Size = new System.Drawing.Size(116, 29);
            this.mnUsuarios.Text = "Usuários";
            // 
            // mnCadUsuario
            // 
            this.mnCadUsuario.Name = "mnCadUsuario";
            this.mnCadUsuario.Size = new System.Drawing.Size(320, 30);
            this.mnCadUsuario.Text = "Cadastro de Usuário";
            this.mnCadUsuario.Click += new System.EventHandler(this.mnCadUsuario_Click);
            // 
            // mnPermissaoUsuario
            // 
            this.mnPermissaoUsuario.Name = "mnPermissaoUsuario";
            this.mnPermissaoUsuario.Size = new System.Drawing.Size(320, 30);
            this.mnPermissaoUsuario.Text = "Permissão de Usuário";
            this.mnPermissaoUsuario.Click += new System.EventHandler(this.mnPermissaoUsuario_Click);
            // 
            // mnConsultaUsuario
            // 
            this.mnConsultaUsuario.Name = "mnConsultaUsuario";
            this.mnConsultaUsuario.Size = new System.Drawing.Size(320, 30);
            this.mnConsultaUsuario.Text = "Consulta Usuário";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(880, 662);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 38);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtUsuarioLogado
            // 
            this.txtUsuarioLogado.Location = new System.Drawing.Point(81, 498);
            this.txtUsuarioLogado.Name = "txtUsuarioLogado";
            this.txtUsuarioLogado.Size = new System.Drawing.Size(777, 26);
            this.txtUsuarioLogado.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.txtUsuarioLogado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYS Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnClientes;
        private System.Windows.Forms.ToolStripMenuItem mnFornecedores;
        private System.Windows.Forms.ToolStripMenuItem mnProdutos;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaCliente;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaFornecedor;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaProduto;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnCompra;
        private System.Windows.Forms.ToolStripMenuItem mnVenda;
        private System.Windows.Forms.ToolStripMenuItem mnEstoque;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnContasAPagar;
        private System.Windows.Forms.ToolStripMenuItem mnContasAReceber;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnRelContasAReceber;
        private System.Windows.Forms.ToolStripMenuItem mnRelContasAPagar;
        private System.Windows.Forms.ToolStripMenuItem mnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnCadUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnPermissaoUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnConsultaUsuario;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuarioLogado;
    }
}

