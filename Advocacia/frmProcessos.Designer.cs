
namespace Advocacia
{
    partial class frmProcessos
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
            this.tabProcessos = new System.Windows.Forms.TabControl();
            this.tabListagem = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDataProcesso = new System.Windows.Forms.Label();
            this.mtbDataProcesso = new System.Windows.Forms.MaskedTextBox();
            this.lblProcesso = new System.Windows.Forms.Label();
            this.lblAdvogado = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboTipoProcesso = new System.Windows.Forms.ComboBox();
            this.cboAdvogado = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tabProcessos.SuspendLayout();
            this.tabListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProcessos
            // 
            this.tabProcessos.Controls.Add(this.tabListagem);
            this.tabProcessos.Controls.Add(this.tabDados);
            this.tabProcessos.Location = new System.Drawing.Point(12, 12);
            this.tabProcessos.Name = "tabProcessos";
            this.tabProcessos.SelectedIndex = 0;
            this.tabProcessos.Size = new System.Drawing.Size(776, 426);
            this.tabProcessos.TabIndex = 0;
            // 
            // tabListagem
            // 
            this.tabListagem.Controls.Add(this.groupBox2);
            this.tabListagem.Controls.Add(this.groupBox1);
            this.tabListagem.Controls.Add(this.dataGridView1);
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
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(756, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.btnNovo);
            this.tabDados.Controls.Add(this.btnVoltar);
            this.tabDados.Controls.Add(this.btnSalvar);
            this.tabDados.Controls.Add(this.lblDataProcesso);
            this.tabDados.Controls.Add(this.mtbDataProcesso);
            this.tabDados.Controls.Add(this.lblProcesso);
            this.tabDados.Controls.Add(this.lblAdvogado);
            this.tabDados.Controls.Add(this.lblCliente);
            this.tabDados.Controls.Add(this.cboTipoProcesso);
            this.tabDados.Controls.Add(this.cboAdvogado);
            this.tabDados.Controls.Add(this.cboCliente);
            this.tabDados.Controls.Add(this.lblDescricao);
            this.tabDados.Controls.Add(this.txtDescricao);
            this.tabDados.Location = new System.Drawing.Point(4, 24);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(768, 398);
            this.tabDados.TabIndex = 1;
            this.tabDados.Text = "Dados";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(525, 369);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(687, 369);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(606, 369);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDataProcesso
            // 
            this.lblDataProcesso.AutoSize = true;
            this.lblDataProcesso.Location = new System.Drawing.Point(24, 71);
            this.lblDataProcesso.Name = "lblDataProcesso";
            this.lblDataProcesso.Size = new System.Drawing.Size(97, 15);
            this.lblDataProcesso.TabIndex = 9;
            this.lblDataProcesso.Text = "Data de Processo";
            // 
            // mtbDataProcesso
            // 
            this.mtbDataProcesso.Location = new System.Drawing.Point(24, 89);
            this.mtbDataProcesso.Name = "mtbDataProcesso";
            this.mtbDataProcesso.Size = new System.Drawing.Size(100, 23);
            this.mtbDataProcesso.TabIndex = 8;
            // 
            // lblProcesso
            // 
            this.lblProcesso.AutoSize = true;
            this.lblProcesso.Location = new System.Drawing.Point(384, 13);
            this.lblProcesso.Name = "lblProcesso";
            this.lblProcesso.Size = new System.Drawing.Size(96, 15);
            this.lblProcesso.TabIndex = 7;
            this.lblProcesso.Text = "Tipo de Processo";
            // 
            // lblAdvogado
            // 
            this.lblAdvogado.AutoSize = true;
            this.lblAdvogado.Location = new System.Drawing.Point(257, 13);
            this.lblAdvogado.Name = "lblAdvogado";
            this.lblAdvogado.Size = new System.Drawing.Size(59, 15);
            this.lblAdvogado.TabIndex = 6;
            this.lblAdvogado.Text = "Advogato";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(130, 13);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente";
            // 
            // cboTipoProcesso
            // 
            this.cboTipoProcesso.FormattingEnabled = true;
            this.cboTipoProcesso.Location = new System.Drawing.Point(384, 31);
            this.cboTipoProcesso.Name = "cboTipoProcesso";
            this.cboTipoProcesso.Size = new System.Drawing.Size(121, 23);
            this.cboTipoProcesso.TabIndex = 4;
            // 
            // cboAdvogado
            // 
            this.cboAdvogado.FormattingEnabled = true;
            this.cboAdvogado.Location = new System.Drawing.Point(257, 31);
            this.cboAdvogado.Name = "cboAdvogado";
            this.cboAdvogado.Size = new System.Drawing.Size(121, 23);
            this.cboAdvogado.TabIndex = 3;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(130, 31);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 23);
            this.cboCliente.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(24, 13);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(24, 31);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 23);
            this.txtDescricao.TabIndex = 0;
            // 
            // frmProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabProcessos);
            this.Name = "frmProcessos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcessos";
            this.tabProcessos.ResumeLayout(false);
            this.tabListagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProcessos;
        private System.Windows.Forms.TabPage tabListagem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblProcesso;
        private System.Windows.Forms.Label lblAdvogado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboTipoProcesso;
        private System.Windows.Forms.ComboBox cboAdvogado;
        private System.Windows.Forms.Label lblDataProcesso;
        private System.Windows.Forms.MaskedTextBox mtbDataProcesso;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
    }
}