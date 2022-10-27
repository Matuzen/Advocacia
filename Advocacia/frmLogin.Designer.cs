 
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lbl_EsqueciASenha = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Login = new System.Windows.Forms.Panel();
            this.lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.pb_Login = new System.Windows.Forms.PictureBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.pn_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).BeginInit();
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
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(25, 70);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(221, 23);
            this.tb_username.TabIndex = 2;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(25, 129);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(221, 23);
            this.tb_senha.TabIndex = 3;
            this.tb_senha.UseSystemPasswordChar = true;
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
            // lbl_EsqueciASenha
            // 
            this.lbl_EsqueciASenha.AutoSize = true;
            this.lbl_EsqueciASenha.Location = new System.Drawing.Point(88, 226);
            this.lbl_EsqueciASenha.Name = "lbl_EsqueciASenha";
            this.lbl_EsqueciASenha.Size = new System.Drawing.Size(90, 15);
            this.lbl_EsqueciASenha.TabIndex = 5;
            this.lbl_EsqueciASenha.TabStop = true;
            this.lbl_EsqueciASenha.Text = "Esqueci a senha";
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
            // pn_Login
            // 
            this.pn_Login.BackColor = System.Drawing.Color.LightGreen;
            this.pn_Login.Controls.Add(this.lbl_NomeUsuario);
            this.pn_Login.Controls.Add(this.lbl_Usuario);
            this.pn_Login.Controls.Add(this.pb_Login);
            this.pn_Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Login.Location = new System.Drawing.Point(0, 263);
            this.pn_Login.Name = "pn_Login";
            this.pn_Login.Size = new System.Drawing.Size(309, 46);
            this.pn_Login.TabIndex = 7;
            // 
            // lbl_NomeUsuario
            // 
            this.lbl_NomeUsuario.AutoSize = true;
            this.lbl_NomeUsuario.Location = new System.Drawing.Point(122, 19);
            this.lbl_NomeUsuario.Name = "lbl_NomeUsuario";
            this.lbl_NomeUsuario.Size = new System.Drawing.Size(22, 15);
            this.lbl_NomeUsuario.TabIndex = 2;
            this.lbl_NomeUsuario.Text = "---";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(66, 19);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(50, 15);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "Usuário:";
            // 
            // pb_Login
            // 
            this.pb_Login.Image = global::Advocacia.Properties.Resources.locked_48;
            this.pb_Login.Location = new System.Drawing.Point(12, 3);
            this.pb_Login.Name = "pb_Login";
            this.pb_Login.Size = new System.Drawing.Size(38, 40);
            this.pb_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login.TabIndex = 0;
            this.pb_Login.TabStop = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(133, 174);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 309);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.pn_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_EsqueciASenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pn_Login.ResumeLayout(false);
            this.pn_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel lbl_EsqueciASenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_Login;
        public System.Windows.Forms.PictureBox pb_Login;
        private System.Windows.Forms.Button btn_Sair;
        public System.Windows.Forms.Label lbl_NomeUsuario;
        public System.Windows.Forms.Label lbl_Usuario;
    }
}