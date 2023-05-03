using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meuSistema
{
    public partial class FrmMeuSistema : Form
    {

        int valor1;
        int valor2;
        int res;


        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            valor1 = int.Parse(txtparc1.Text);
            valor2 = int.Parse(txtparc2.Text);

            res = valor1 + valor2;
            txtRes.Text = Convert.ToString(res);
        }
    }
}
