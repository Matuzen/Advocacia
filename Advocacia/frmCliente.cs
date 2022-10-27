using Advocacia.Models;
using System;
using System.Windows.Forms;

namespace Advocacia
{
    public partial class frmCliente : Form
    {
        #region Variaveis

        Client client = new Client();

        #endregion

        #region Componentes

        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = "";
                txtRG.Text = "";
                mktDataNascimento.Text = "";
                txtEmail.Text = "";
                mktTelefone.Text = "";
                mktCEP.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                cboEstado.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacao() == true)
                {
                    Salvar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Métodos

        public bool Validacao()
        {
            if (txtNome.Text == "")
            {
                return false;
            }

            if (txtRG.Text == "")
            {
                return false;
            }

            if (txtEmail.Text == "")
            {
                return false;
            }

            if (mktDataNascimento.Text == "")
            {
                return false;
            }

            if (mktTelefone.Text == "")
            {
                return false;
            }

            if (mktCEP.Text == "")
            {
                return false;
            }

            if (txtEndereco.Text == "")
            {
                return false;
            }

            if (txtNumero.Text == "")
            {
                return false;
            }

            if (txtBairro.Text == "")
            {
                return false;
            }

            if (txtCidade.Text == "")
            {
                return false;
            }

            if (cboEstado.SelectedIndex == -1)
            {
                return false;
            }
            
            return true;
        }

        public void Salvar()
        {
            try
            {
                client.Name = txtNome.Text;
                client.RG = txtRG.Text;
                client.Birth_Date = Convert.ToDateTime(mktDataNascimento.Text);
                client.Email = txtEmail.Text;
                client.Phone = mktTelefone.Text;
                client.Id = (long)btnSalvar.Tag;
                client.Address_Code = mktCEP.Text;
                client.Address = txtEndereco.Text;
                client.Number = Convert.ToInt32(txtNumero.Text);
                client.District = txtBairro.Text;
                client.City = txtCidade.Text;
                client.State = cboEstado.SelectedValue.ToString();
                
                // Se nao tiver o código, inserir o novo cliente
                if (btnSalvar.Tag != null)
                {
                    btnSalvar.Tag = client.Insert(client);
                }
                else
                {
                    client.Update(client);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        #endregion

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
