using Advocacia.Controllers;
using Advocacia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advocacia
{
    public partial class frmProcessos : Form
    {
        Process process = new Process();
        ProcessController processController = new ProcessController();

        public frmProcessos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Salvar()
        {
            try
            {
                process.Description = txtDescricao.Text;
                process.Id_Client = (long)cboCliente.SelectedValue;
                process.Id_Lawyer = (long)cboAdvogado.SelectedValue;
                process.Id_Process_Type = (long)cboTipoProcesso.SelectedValue;
                process.Process_Date = Convert.ToDateTime(mtbDataProcesso.Text); //converter o texto para data

                processController.Insert(process);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                txtDescricao.Text = "";
                cboCliente.SelectedIndex = -1;
                cboAdvogado.SelectedIndex = -1;
                cboTipoProcesso.SelectedIndex = -1;
                mtbDataProcesso.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
