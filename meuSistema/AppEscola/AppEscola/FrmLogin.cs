using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
             if(txtNome.Text == "")
            {
                MessageBox.Show("Digite um nome");
                return;
            }
            if (txtSenha.Text == "123")
            {
                FrmPrincipal frm = new FrmPrincipal();
                frm.ShowDialog();

                this.Close();
            } else
            {
                MessageBox.Show("Digite a senha");
                return;
            }

            Program.usuario = txtNome.Text;

        }
    }
}
