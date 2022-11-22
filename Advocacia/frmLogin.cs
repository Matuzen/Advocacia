using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advocacia.Classes;
using Advocacia.Classes.Controllers;

namespace Advocacia
{
    public partial class frmLogin : Form
    {
        #region VÁRIAVEIS

        LoginController loginController = new LoginController();

        #endregion

        #region CONTROLES

        public frmLogin()
        {
            InitializeComponent();
            // Quando eu chamar esse formulário frmLogin através do frmMenu eu vou passar o próprio frmMenu pra ele
            // Assim eu consigo utilizar os elementos de frmMenu dentro do frmLogin - Manipulação de elementos
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Globais.logado == false)
                Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaUsuario())
                {
                    Login();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region MÉTODOS

        public bool ValidaUsuario()
        {
            try
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Usuário é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                    return false;
                }

                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Senha é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSenha.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Login()
        {
            try
            {
                loginController.User = txtUsuario.Text;
                loginController.Password = txtSenha.Text;
                
                if (loginController.Login())
                {
                    frmMenu menu = new frmMenu();

                    // menu.lbl_NomeUsuario.Text = dt.Rows[2].ItemArray[1].ToString();
                    menu.pb_Logado.Image = Properties.Resources.unlocked_48;
                    Globais.logado = true;

                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
