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

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
