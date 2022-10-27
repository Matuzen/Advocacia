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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void calendariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcessos processos = new frmProcessos();
            processos.ShowDialog();
        }

        private void meuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeuPerfil meuperfil = new frmMeuPerfil();
            meuperfil.ShowDialog();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracoes configuracoes = new frmConfiguracoes();
            configuracoes.ShowDialog();
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagamentos pagamentos = new frmPagamentos();
            pagamentos.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
