using System.Windows.Forms;

namespace MinhaAplicação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Calculo c = new Calculo();
            int tipoProduto = 0;

            if (rdSuco.Checked)
            {
                tipoProduto = 1;
            }
            else if (rdTv.Checked)
            {
                tipoProduto = 2;
            }
            else if (rdRadio.Checked)
            {
                tipoProduto = 3;
            }

            int precoInicial = Convert.ToInt32(txtBox.Text);

            MessageBox.Show("O preço final é: " + c.MostrarPreco(precoInicial, tipoProduto));

            

            
        }
    }
}