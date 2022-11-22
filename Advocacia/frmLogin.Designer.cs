 
namespace Advocacia
{
    partial class frmLogin
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioTexto = new System.Windows.Forms.Label();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(25, 52);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(25, 111);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 15);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(25, 70);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 23);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(25, 129);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(221, 23);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(25, 174);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(73, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.AutoSize = true;
            this.lblEsqueciSenha.Location = new System.Drawing.Point(88, 226);
            this.lblEsqueciSenha.Name = "lblEsqueciSenha";
            this.lblEsqueciSenha.Size = new System.Drawing.Size(90, 15);
            this.lblEsqueciSenha.TabIndex = 5;
            this.lblEsqueciSenha.TabStop = true;
            this.lblEsqueciSenha.Text = "Esqueci a senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Top Service Advocacia";
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.LightGreen;
            this.pnLogin.Controls.Add(this.lblNomeUsuario);
            this.pnLogin.Controls.Add(this.lblUsuarioTexto);
            this.pnLogin.Controls.Add(this.pbLogin);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLogin.Location = new System.Drawing.Point(0, 263);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(309, 46);
            this.pnLogin.TabIndex = 7;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(122, 19);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(22, 15);
            this.lblNomeUsuario.TabIndex = 2;
            this.lblNomeUsuario.Text = "---";
            // 
            // lblUsuarioTexto
            // 
            this.lblUsuarioTexto.AutoSize = true;
            this.lblUsuarioTexto.Location = new System.Drawing.Point(66, 19);
            this.lblUsuarioTexto.Name = "lblUsuarioTexto";
            this.lblUsuarioTexto.Size = new System.Drawing.Size(50, 15);
            this.lblUsuarioTexto.TabIndex = 1;
            this.lblUsuarioTexto.Text = "Usuário:";
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::Advocacia.Properties.Resources.locked_48;
            this.pbLogin.Location = new System.Drawing.Point(12, 3);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(38, 40);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 0;
            this.pbLogin.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(133, 174);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 309);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEsqueciSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel lblEsqueciSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLogin;
        public System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Label lblNomeUsuario;
        public System.Windows.Forms.Label lblUsuarioTexto;
    }
}