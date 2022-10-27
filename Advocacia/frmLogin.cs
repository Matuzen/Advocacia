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


namespace Advocacia
{
    public partial class frmLogin : Form
    {        
        DataTable dt = new DataTable();
        public frmLogin()
        {
            InitializeComponent();
            // Quando eu chamar esse formulário frmLogin através do frmMenu eu vou passar o próprio frmMenu pra ele
            // Assim eu consigo utilizar os elementos de frmMenu dentro do frmLogin - Manipulação de elementos
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Colhendo as informações digitadas
            string username = tb_username.Text;
            string senha = tb_senha.Text;

            // Verificando se os campos estão preenchidos
            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário ou Senha inválidos");
                tb_username.Focus();
                return; // Se essa condição for true o return interrompe a execução do programa
            }

            string sql = "SELECT * FROM Lawyers WHERE NAME='" + username + "'AND Password='" + senha + "'";

            // chamar o método consulta e armazenar o retorno dele no DataTable
            dt = Banco.Consulta(sql);
            if (dt.Rows.Count == 1)
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
                MessageBox.Show("Usuário não encontrado");
            }

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Globais.logado == false)
                Application.Exit();
        }
    }
}
