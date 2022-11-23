using Advocacia.Models;
using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using Advocacia.Classes.Controllers;

namespace Advocacia
{
    public partial class frmCliente : Form
    {
        #region Variaveis

        Client client = new Client();
        ClientControlller clientControlller = new ClientControlller();
        string maskPhone = "(   )    -";

        #endregion

        #region Componentes

        public frmCliente()
        {
            InitializeComponent();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Excluir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                Novo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Métodos

        public void Novo()
        {
            try
            {
                txtNome.Text = "";
                txtRG.Text = "";
                txtDataNascimento.Text = "";
                txtEmail.Text = "";
                txtTelefone.Text = "";
                txtCEP.Text = "";
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                cboEstado.SelectedIndex = -1;
                btnSalvar.Tag = null;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public bool Validacao()
        {
            try
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Nome é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                    return false;
                }

                if (txtRG.Text == "")
                {
                    MessageBox.Show("RG é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRG.Focus();
                    return false;
                }

                if (txtDataNascimento.Text == "")
                {
                    MessageBox.Show("Data de Nascimento é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDataNascimento.Focus();
                    return false;
                }

                if (txtTelefone.Text == "")
                {
                    MessageBox.Show("Telefone é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTelefone.Focus();
                    return false;
                }

                if (txtEndereco.Text == "")
                {
                    MessageBox.Show("Endereço é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEndereco.Focus();
                    return false;
                }

                if (txtNumero.Text == "")
                {
                    MessageBox.Show("Número é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumero.Focus();
                    return false;
                }

                if (txtBairro.Text == "")
                {
                    MessageBox.Show("Bairro é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBairro.Focus();
                    return false;
                }

                if (txtCidade.Text == "")
                {
                    MessageBox.Show("Cidade é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCidade.Focus();
                    return false;
                }

                if (cboEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Estado é um Campo Obrigatório", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboEstado.Focus();
                    return false;
                }

                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Salvar()
        {
            try
            {
                client.Name = txtNome.Text;
                client.RG = txtRG.Text;
                client.Birth_Date = Convert.ToDateTime(txtDataNascimento.Text);
                client.Email = txtEmail.Text;
                client.Phone = txtTelefone.Text;
                client.Address_Code = txtCEP.Text;
                client.Address = txtEndereco.Text;
                client.Number = Convert.ToInt32(txtNumero.Text);
                client.District = txtBairro.Text;
                client.City = txtCidade.Text;
                client.State = cboEstado.SelectedItem.ToString();
                client.Id = btnSalvar.Tag == null ? null : (long) btnSalvar.Tag;
                
                // Se não tiver o código, inserir o novo cliente
                if (btnSalvar.Tag == null)
                {
                    btnSalvar.Tag = clientControlller.Insert(client);
                    MessageBox.Show("Cliente Inserido com Sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clientControlller.Update(client);
                    MessageBox.Show("Cliente Alterado com Sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir()
        {
            try
            {
                long id;

                if (MessageBox.Show("Deseja Realmente Excluir Esse Cliente?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = (long)grdListagem.Rows[grdListagem.SelectedRows[0].Index].Cells["id"].Value;

                    clientControlller.Delete(id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Load()
        {
            try
            {
                clientControlller.Load(txtNomeFiltro.Text,
                                       txtRGFiltro.Text,
                                       txtTelefoneFiltro.Text.Trim() == maskPhone ? "" : txtTelefoneFiltro.Text,
                                       grdListagem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
