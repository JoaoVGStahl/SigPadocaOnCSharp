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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //Configurando LabelLink
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "Esqueceu a senha?";
            linkLabel1.Links.Add(0, 17, "https://www.google.com.br");
        }
        //Redirecionamento LabelLink
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        //Verificação de Senha
        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario, Senha;
            Usuario = "Joao";
            Senha = "12345";
            if (TxtUsuario.Text == Usuario && TxtSenha.Text == Senha)
            {
                FrmMenuPrincipal Frm = new FrmMenuPrincipal();
                Frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorretos!");
            }

        }
    }
}
