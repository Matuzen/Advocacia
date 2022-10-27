
using System;

namespace Advocacia
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meuPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.pb_Logado = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pn_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logado)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meuPerfilToolStripMenuItem,
            this.calendariToolStripMenuItem,
            this.calendárioToolStripMenuItem,
            this.pagamentosToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meuPerfilToolStripMenuItem
            // 
            this.meuPerfilToolStripMenuItem.Name = "meuPerfilToolStripMenuItem";
            this.meuPerfilToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.meuPerfilToolStripMenuItem.Text = "Alterar Senha";
            this.meuPerfilToolStripMenuItem.Click += new System.EventHandler(this.meuPerfilToolStripMenuItem_Click);
            // 
            // calendariToolStripMenuItem
            // 
            this.calendariToolStripMenuItem.Name = "calendariToolStripMenuItem";
            this.calendariToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.calendariToolStripMenuItem.Text = "Processos";
            this.calendariToolStripMenuItem.Click += new System.EventHandler(this.calendariToolStripMenuItem_Click);
            // 
            // calendárioToolStripMenuItem
            // 
            this.calendárioToolStripMenuItem.Name = "calendárioToolStripMenuItem";
            this.calendárioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.calendárioToolStripMenuItem.Text = "Agenda";
            this.calendárioToolStripMenuItem.Click += new System.EventHandler(this.calendárioToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.pagamentosToolStripMenuItem.Text = "Financeiro";
            this.pagamentosToolStripMenuItem.Click += new System.EventHandler(this.pagamentosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configuração";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // pn_Menu
            // 
            this.pn_Menu.BackColor = System.Drawing.Color.LightGreen;
            this.pn_Menu.Controls.Add(this.lbl_NomeUsuario);
            this.pn_Menu.Controls.Add(this.lbl_Usuario);
            this.pn_Menu.Controls.Add(this.pb_Logado);
            this.pn_Menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Menu.Location = new System.Drawing.Point(0, 404);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(800, 46);
            this.pn_Menu.TabIndex = 1;
            // 
            // lbl_NomeUsuario
            // 
            this.lbl_NomeUsuario.AutoSize = true;
            this.lbl_NomeUsuario.Location = new System.Drawing.Point(122, 14);
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
            // pb_Logado
            // 
            this.pb_Logado.Image = global::Advocacia.Properties.Resources.unlocked_48;
            this.pb_Logado.Location = new System.Drawing.Point(12, 3);
            this.pb_Logado.Name = "pb_Logado";
            this.pb_Logado.Size = new System.Drawing.Size(38, 40);
            this.pb_Logado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logado.TabIndex = 0;
            this.pb_Logado.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_Menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pn_Menu.ResumeLayout(false);
            this.pn_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalendario calendario = new frmCalendario();
            calendario.ShowDialog();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calendariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meuPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.Panel pn_Menu;
        public System.Windows.Forms.PictureBox pb_Logado;
        public System.Windows.Forms.Label lbl_NomeUsuario;
        public System.Windows.Forms.Label lbl_Usuario;
    }
}

