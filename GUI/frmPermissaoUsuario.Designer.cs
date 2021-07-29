namespace GUI
{
    partial class frmPermissaoUsuario
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvDadosPermissao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLocalizarPermissao = new System.Windows.Forms.Button();
            this.per_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFrm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inserir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alterar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPermissao)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Location = new System.Drawing.Point(5, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 105);
            this.panel2.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::GUI.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(760, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 85);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::GUI.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(573, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(143, 85);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::GUI.Properties.Resources.delete1;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(386, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(143, 85);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::GUI.Properties.Resources.edit1;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(12, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(143, 85);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::GUI.Properties.Resources.search2;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(199, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(143, 85);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // dgvDadosPermissao
            // 
            this.dgvDadosPermissao.AllowUserToAddRows = false;
            this.dgvDadosPermissao.AllowUserToDeleteRows = false;
            this.dgvDadosPermissao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDadosPermissao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosPermissao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.per_id,
            this.nomeFrm,
            this.descricao,
            this.bloqueado,
            this.inserir,
            this.alterar,
            this.Excluir,
            this.imprimir});
            this.dgvDadosPermissao.Location = new System.Drawing.Point(21, 98);
            this.dgvDadosPermissao.Name = "dgvDadosPermissao";
            this.dgvDadosPermissao.RowHeadersVisible = false;
            this.dgvDadosPermissao.RowTemplate.Height = 28;
            this.dgvDadosPermissao.Size = new System.Drawing.Size(902, 282);
            this.dgvDadosPermissao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(100, 15);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(680, 26);
            this.txtValor.TabIndex = 5;
            // 
            // btnLocalizarPermissao
            // 
            this.btnLocalizarPermissao.Location = new System.Drawing.Point(786, 13);
            this.btnLocalizarPermissao.Name = "btnLocalizarPermissao";
            this.btnLocalizarPermissao.Size = new System.Drawing.Size(107, 30);
            this.btnLocalizarPermissao.TabIndex = 6;
            this.btnLocalizarPermissao.Text = "Localizar";
            this.btnLocalizarPermissao.UseVisualStyleBackColor = true;
            this.btnLocalizarPermissao.Click += new System.EventHandler(this.btnLocalizarPermissao_Click);
            // 
            // per_id
            // 
            this.per_id.HeaderText = "PerId";
            this.per_id.Name = "per_id";
            this.per_id.Visible = false;
            // 
            // nomeFrm
            // 
            this.nomeFrm.HeaderText = "nmFrm";
            this.nomeFrm.Name = "nomeFrm";
            this.nomeFrm.Visible = false;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Formulario";
            this.descricao.Name = "descricao";
            this.descricao.Width = 250;
            // 
            // bloqueado
            // 
            this.bloqueado.HeaderText = "Bloqueado";
            this.bloqueado.Name = "bloqueado";
            this.bloqueado.Width = 70;
            // 
            // inserir
            // 
            this.inserir.HeaderText = "Inserir";
            this.inserir.Name = "inserir";
            this.inserir.Width = 70;
            // 
            // alterar
            // 
            this.alterar.HeaderText = "Alterar";
            this.alterar.Name = "alterar";
            this.alterar.Width = 70;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 70;
            // 
            // imprimir
            // 
            this.imprimir.HeaderText = "Imprimir";
            this.imprimir.Name = "imprimir";
            this.imprimir.Width = 70;
            // 
            // frmPermissaoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 494);
            this.Controls.Add(this.btnLocalizarPermissao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDadosPermissao);
            this.Controls.Add(this.panel2);
            this.Name = "frmPermissaoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definir Permissões do Usuário";
            this.Load += new System.EventHandler(this.frmPermissaoUsuario_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPermissao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvDadosPermissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnLocalizarPermissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn per_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFrm;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bloqueado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inserir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alterar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn imprimir;
    }
}