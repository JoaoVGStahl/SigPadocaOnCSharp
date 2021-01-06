using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigPadoca
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        public void Sair()
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region Código da Barra de Status
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            string dataCompleta = DateTime.Now.ToLongDateString();
            string Semana = dataCompleta.Substring(0, 1).ToUpper() + dataCompleta.Substring(1, dataCompleta.Length - 1);
            StripData.Text = Semana;
            timer1.Enabled = true;
        }
        #endregion
        #region Código do Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            StripHora.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCalcCalorias_Click(object sender, EventArgs e)
        {         

        }

        private void FrmMenuPrincipal_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmCadastroClientes Frm = new FrmCadastroClientes();
            Frm.Show();
            Hide();
        }
    }
}
