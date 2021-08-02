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
            this.per_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFrm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inserir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alterar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnLocalizarPermissao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsuarioPesquisado = new System.Windows.Forms.TextBox();
            this.gbxMarcarTodos = new System.Windows.Forms.GroupBox();
            this.chxMarcaImprimir = new System.Windows.Forms.CheckBox();
            this.chxMarcaExcluir = new System.Windows.Forms.CheckBox();
            this.chxMarcaAlterar = new System.Windows.Forms.CheckBox();
            this.chxMarcaInserir = new System.Windows.Forms.CheckBox();
            this.chxMarcaBloqueado = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPermissao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxMarcarTodos.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(1, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 105);
            this.panel2.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::GUI.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(796, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 85);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::GUI.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(600, 17);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(143, 85);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::GUI.Properties.Resources.delete1;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(404, 19);
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
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::GUI.Properties.Resources.search2;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(208, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(143, 85);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.dgvDadosPermissao.Location = new System.Drawing.Point(12, 205);
            this.dgvDadosPermissao.Name = "dgvDadosPermissao";
            this.dgvDadosPermissao.RowHeadersVisible = false;
            this.dgvDadosPermissao.RowTemplate.Height = 28;
            this.dgvDadosPermissao.Size = new System.Drawing.Size(946, 327);
            this.dgvDadosPermissao.TabIndex = 3;
            this.dgvDadosPermissao.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDadosPermissao_DataError);
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
            this.bloqueado.FalseValue = "\"False\"";
            this.bloqueado.HeaderText = "Bloqueado";
            this.bloqueado.Name = "bloqueado";
            this.bloqueado.TrueValue = "\"True\"";
            this.bloqueado.Width = 70;
            // 
            // inserir
            // 
            this.inserir.FalseValue = "\"False\"";
            this.inserir.HeaderText = "Inserir";
            this.inserir.Name = "inserir";
            this.inserir.TrueValue = "\"True\"";
            this.inserir.Width = 70;
            // 
            // alterar
            // 
            this.alterar.FalseValue = "\"False\"";
            this.alterar.HeaderText = "Alterar";
            this.alterar.Name = "alterar";
            this.alterar.TrueValue = "\"True\"";
            this.alterar.Width = 70;
            // 
            // Excluir
            // 
            this.Excluir.FalseValue = "\"False\"";
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.TrueValue = "\"True\"";
            this.Excluir.Width = 70;
            // 
            // imprimir
            // 
            this.imprimir.FalseValue = "\"False\"";
            this.imprimir.HeaderText = "Imprimir";
            this.imprimir.Name = "imprimir";
            this.imprimir.TrueValue = "\"True\"";
            this.imprimir.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código do Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(34, 28);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(680, 26);
            this.txtValor.TabIndex = 5;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // btnLocalizarPermissao
            // 
            this.btnLocalizarPermissao.Location = new System.Drawing.Point(732, 26);
            this.btnLocalizarPermissao.Name = "btnLocalizarPermissao";
            this.btnLocalizarPermissao.Size = new System.Drawing.Size(107, 30);
            this.btnLocalizarPermissao.TabIndex = 6;
            this.btnLocalizarPermissao.Text = "Localizar";
            this.btnLocalizarPermissao.UseVisualStyleBackColor = true;
            this.btnLocalizarPermissao.Click += new System.EventHandler(this.btnLocalizarPermissao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsuarioPesquisado);
            this.groupBox1.Location = new System.Drawing.Point(21, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissões do usuário";
            // 
            // txtUsuarioPesquisado
            // 
            this.txtUsuarioPesquisado.Enabled = false;
            this.txtUsuarioPesquisado.Location = new System.Drawing.Point(13, 25);
            this.txtUsuarioPesquisado.Name = "txtUsuarioPesquisado";
            this.txtUsuarioPesquisado.Size = new System.Drawing.Size(687, 26);
            this.txtUsuarioPesquisado.TabIndex = 8;
            // 
            // gbxMarcarTodos
            // 
            this.gbxMarcarTodos.Controls.Add(this.chxMarcaImprimir);
            this.gbxMarcarTodos.Controls.Add(this.chxMarcaExcluir);
            this.gbxMarcarTodos.Controls.Add(this.chxMarcaAlterar);
            this.gbxMarcarTodos.Controls.Add(this.chxMarcaInserir);
            this.gbxMarcarTodos.Controls.Add(this.chxMarcaBloqueado);
            this.gbxMarcarTodos.Location = new System.Drawing.Point(258, 135);
            this.gbxMarcarTodos.Name = "gbxMarcarTodos";
            this.gbxMarcarTodos.Size = new System.Drawing.Size(646, 65);
            this.gbxMarcarTodos.TabIndex = 9;
            this.gbxMarcarTodos.TabStop = false;
            this.gbxMarcarTodos.Text = "Marcar / Desmarcar Todos";
            // 
            // chxMarcaImprimir
            // 
            this.chxMarcaImprimir.AutoSize = true;
            this.chxMarcaImprimir.Location = new System.Drawing.Point(583, 30);
            this.chxMarcaImprimir.Name = "chxMarcaImprimir";
            this.chxMarcaImprimir.Size = new System.Drawing.Size(22, 21);
            this.chxMarcaImprimir.TabIndex = 4;
            this.chxMarcaImprimir.UseVisualStyleBackColor = true;
            this.chxMarcaImprimir.CheckedChanged += new System.EventHandler(this.chxMarcaImprimir_CheckedChanged);
            // 
            // chxMarcaExcluir
            // 
            this.chxMarcaExcluir.AutoSize = true;
            this.chxMarcaExcluir.Location = new System.Drawing.Point(489, 30);
            this.chxMarcaExcluir.Name = "chxMarcaExcluir";
            this.chxMarcaExcluir.Size = new System.Drawing.Size(22, 21);
            this.chxMarcaExcluir.TabIndex = 3;
            this.chxMarcaExcluir.UseVisualStyleBackColor = true;
            this.chxMarcaExcluir.CheckedChanged += new System.EventHandler(this.chxMarcaExcluir_CheckedChanged);
            // 
            // chxMarcaAlterar
            // 
            this.chxMarcaAlterar.AutoSize = true;
            this.chxMarcaAlterar.Location = new System.Drawing.Point(378, 31);
            this.chxMarcaAlterar.Name = "chxMarcaAlterar";
            this.chxMarcaAlterar.Size = new System.Drawing.Size(22, 21);
            this.chxMarcaAlterar.TabIndex = 2;
            this.chxMarcaAlterar.UseVisualStyleBackColor = true;
            this.chxMarcaAlterar.CheckedChanged += new System.EventHandler(this.chxMarcaAlterar_CheckedChanged);
            // 
            // chxMarcaInserir
            // 
            this.chxMarcaInserir.AutoSize = true;
            this.chxMarcaInserir.Location = new System.Drawing.Point(276, 31);
            this.chxMarcaInserir.Name = "chxMarcaInserir";
            this.chxMarcaInserir.Size = new System.Drawing.Size(22, 21);
            this.chxMarcaInserir.TabIndex = 1;
            this.chxMarcaInserir.UseVisualStyleBackColor = true;
            this.chxMarcaInserir.CheckedChanged += new System.EventHandler(this.chxMarcaInserir_CheckedChanged);
            // 
            // chxMarcaBloqueado
            // 
            this.chxMarcaBloqueado.AutoSize = true;
            this.chxMarcaBloqueado.Location = new System.Drawing.Point(171, 31);
            this.chxMarcaBloqueado.Name = "chxMarcaBloqueado";
            this.chxMarcaBloqueado.Size = new System.Drawing.Size(22, 21);
            this.chxMarcaBloqueado.TabIndex = 0;
            this.chxMarcaBloqueado.UseVisualStyleBackColor = true;
            this.chxMarcaBloqueado.CheckedChanged += new System.EventHandler(this.chxMarcaBloqueado_CheckedChanged);
            // 
            // frmPermissaoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 656);
            this.Controls.Add(this.gbxMarcarTodos);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxMarcarTodos.ResumeLayout(false);
            this.gbxMarcarTodos.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsuarioPesquisado;
        private System.Windows.Forms.GroupBox gbxMarcarTodos;
        private System.Windows.Forms.CheckBox chxMarcaImprimir;
        private System.Windows.Forms.CheckBox chxMarcaExcluir;
        private System.Windows.Forms.CheckBox chxMarcaAlterar;
        private System.Windows.Forms.CheckBox chxMarcaInserir;
        private System.Windows.Forms.CheckBox chxMarcaBloqueado;
    }
}