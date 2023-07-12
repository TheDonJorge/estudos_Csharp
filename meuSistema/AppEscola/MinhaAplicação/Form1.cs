using System.Windows.Forms;
using System.IO;
using System.Text;

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

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter arq = new StreamWriter(@"D:\Arquivo.txt", false, Encoding.UTF8);

            arq.WriteLine("Minha primeira linha de texto");

            arq.Dispose();

        }
    }
}