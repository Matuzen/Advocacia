
namespace Advocacia
{
    partial class frmCliente
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
            this.tabCliente = new System.Windows.Forms.TabControl();
            this.tabListagem = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtTelefoneFiltro = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneFiltro = new System.Windows.Forms.Label();
            this.txtRGFiltro = new System.Windows.Forms.MaskedTextBox();
            this.lblRGFiltro = new System.Windows.Forms.Label();
            this.lblNomeFiltro = new System.Windows.Forms.Label();
            this.txtNomeFiltro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNovoRegistro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grdListagem = new System.Windows.Forms.DataGridView();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabCliente.SuspendLayout();
            this.tabListagem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListagem)).BeginInit();
            this.tabDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.tabListagem);
            this.tabCliente.Controls.Add(this.tabDados);
            this.tabCliente.Location = new System.Drawing.Point(14, 12);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(776, 426);
            this.tabCliente.TabIndex = 1;
            // 
            // tabListagem
            // 
            this.tabListagem.Controls.Add(this.groupBox2);
            this.tabListagem.Controls.Add(this.groupBox1);
            this.tabListagem.Controls.Add(this.grdListagem);
            this.tabListagem.Location = new System.Drawing.Point(4, 24);
            this.tabListagem.Name = "tabListagem";
            this.tabListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tabListagem.Size = new System.Drawing.Size(768, 398);
            this.tabListagem.TabIndex = 0;
            this.tabListagem.Text = "Listagem";
            this.tabListagem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Controls.Add(this.txtTelefoneFiltro);
            this.groupBox2.Controls.Add(this.lblTelefoneFiltro);
            this.groupBox2.Controls.Add(this.txtRGFiltro);
            this.groupBox2.Controls.Add(this.lblRGFiltro);
            this.groupBox2.Controls.Add(this.lblNomeFiltro);
            this.groupBox2.Controls.Add(this.txtNomeFiltro);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Location = new System.Drawing.Point(678, 32);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 29;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtTelefoneFiltro
            // 
            this.txtTelefoneFiltro.Location = new System.Drawing.Point(340, 32);
            this.txtTelefoneFiltro.Mask = "(999) 000-0000";
            this.txtTelefoneFiltro.Name = "txtTelefoneFiltro";
            this.txtTelefoneFiltro.Size = new System.Drawing.Size(114, 23);
            this.txtTelefoneFiltro.TabIndex = 25;
            // 
            // lblTelefoneFiltro
            // 
            this.lblTelefoneFiltro.AutoSize = true;
            this.lblTelefoneFiltro.Location = new System.Drawing.Point(340, 14);
            this.lblTelefoneFiltro.Name = "lblTelefoneFiltro";
            this.lblTelefoneFiltro.Size = new System.Drawing.Size(51, 15);
            this.lblTelefoneFiltro.TabIndex = 24;
            this.lblTelefoneFiltro.Text = "Telefone";
            // 
            // txtRGFiltro
            // 
            this.txtRGFiltro.Location = new System.Drawing.Point(234, 32);
            this.txtRGFiltro.Name = "txtRGFiltro";
            this.txtRGFiltro.Size = new System.Drawing.Size(100, 23);
            this.txtRGFiltro.TabIndex = 23;
            // 
            // lblRGFiltro
            // 
            this.lblRGFiltro.AutoSize = true;
            this.lblRGFiltro.Location = new System.Drawing.Point(231, 14);
            this.lblRGFiltro.Name = "lblRGFiltro";
            this.lblRGFiltro.Size = new System.Drawing.Size(22, 15);
            this.lblRGFiltro.TabIndex = 22;
            this.lblRGFiltro.Text = "RG";
            // 
            // lblNomeFiltro
            // 
            this.lblNomeFiltro.AutoSize = true;
            this.lblNomeFiltro.Location = new System.Drawing.Point(6, 14);
            this.lblNomeFiltro.Name = "lblNomeFiltro";
            this.lblNomeFiltro.Size = new System.Drawing.Size(40, 15);
            this.lblNomeFiltro.TabIndex = 21;
            this.lblNomeFiltro.Text = "Nome";
            // 
            // txtNomeFiltro
            // 
            this.txtNomeFiltro.Location = new System.Drawing.Point(6, 32);
            this.txtNomeFiltro.Name = "txtNomeFiltro";
            this.txtNomeFiltro.Size = new System.Drawing.Size(222, 23);
            this.txtNomeFiltro.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNovoRegistro);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Location = new System.Drawing.Point(6, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoRegistro.Location = new System.Drawing.Point(519, 34);
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnNovoRegistro.TabIndex = 28;
            this.btnNovoRegistro.Text = "Novo";
            this.btnNovoRegistro.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(681, 34);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(600, 34);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // grdListagem
            // 
            this.grdListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            this.grdListagem.Location = new System.Drawing.Point(6, 88);
            this.grdListagem.Name = "grdListagem";
            this.grdListagem.RowTemplate.Height = 25;
            this.grdListagem.Size = new System.Drawing.Size(756, 231);
            this.grdListagem.TabIndex = 0;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.cboEstado);
            this.tabDados.Controls.Add(this.lblEstado);
            this.tabDados.Controls.Add(this.lblCidade);
            this.tabDados.Controls.Add(this.txtCidade);
            this.tabDados.Controls.Add(this.lblBairro);
            this.tabDados.Controls.Add(this.txtBairro);
            this.tabDados.Controls.Add(this.txtNumero);
            this.tabDados.Controls.Add(this.lblNumero);
            this.tabDados.Controls.Add(this.lblEndereco);
            this.tabDados.Controls.Add(this.txtEndereco);
            this.tabDados.Controls.Add(this.lblCEP);
            this.tabDados.Controls.Add(this.txtCEP);
            this.tabDados.Controls.Add(this.txtTelefone);
            this.tabDados.Controls.Add(this.lblTelefone);
            this.tabDados.Controls.Add(this.lblEmail);
            this.tabDados.Controls.Add(this.txtEmail);
            this.tabDados.Controls.Add(this.txtRG);
            this.tabDados.Controls.Add(this.btnNovo);
            this.tabDados.Controls.Add(this.btnVoltar);
            this.tabDados.Controls.Add(this.btnSalvar);
            this.tabDados.Controls.Add(this.lblDataNascimento);
            this.tabDados.Controls.Add(this.txtDataNascimento);
            this.tabDados.Controls.Add(this.lblRG);
            this.tabDados.Controls.Add(this.lblNome);
            this.tabDados.Controls.Add(this.txtNome);
            this.tabDados.Location = new System.Drawing.Point(4, 24);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(768, 398);
            this.tabDados.TabIndex = 1;
            this.tabDados.Text = "Dados";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cboEstado.Location = new System.Drawing.Point(150, 153);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(99, 23);
            this.cboEstado.TabIndex = 32;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(150, 135);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(13, 135);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 15);
            this.lblCidade.TabIndex = 29;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(13, 153);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(131, 23);
            this.txtCidade.TabIndex = 28;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(539, 66);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 15);
            this.lblBairro.TabIndex = 27;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(539, 84);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(131, 23);
            this.txtBairro.TabIndex = 26;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(481, 84);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(48, 23);
            this.txtNumero.TabIndex = 25;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(478, 66);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 24;
            this.lblNumero.Text = "Número";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(253, 66);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 15);
            this.lblEndereco.TabIndex = 23;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(253, 84);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(222, 23);
            this.txtEndereco.TabIndex = 22;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(133, 66);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 15);
            this.lblCEP.TabIndex = 21;
            this.lblCEP.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(133, 84);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(114, 23);
            this.txtCEP.TabIndex = 20;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(13, 84);
            this.txtTelefone.Mask = "(999) 000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(114, 23);
            this.txtTelefone.TabIndex = 19;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 66);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(51, 15);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(467, 8);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(467, 26);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(241, 26);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 23);
            this.txtRG.TabIndex = 14;
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(525, 359);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(687, 359);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(606, 359);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(347, 8);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(114, 15);
            this.lblDataNascimento.TabIndex = 9;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(347, 26);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(114, 23);
            this.txtDataNascimento.TabIndex = 8;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(238, 8);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(22, 15);
            this.lblRG.TabIndex = 5;
            this.lblRG.Text = "RG";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(222, 23);
            this.txtNome.TabIndex = 0;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Width = 40;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.tabCliente.ResumeLayout(false);
            this.tabListagem.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListagem)).EndInit();
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCliente;
        private System.Windows.Forms.TabPage tabListagem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdListagem;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFiltro;
        private System.Windows.Forms.Label lblTelefoneFiltro;
        private System.Windows.Forms.MaskedTextBox txtRGFiltro;
        private System.Windows.Forms.Label lblRGFiltro;
        private System.Windows.Forms.Label lblNomeFiltro;
        private System.Windows.Forms.TextBox txtNomeFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnNovoRegistro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}