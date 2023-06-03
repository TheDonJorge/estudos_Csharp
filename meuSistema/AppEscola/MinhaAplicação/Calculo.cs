using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaAplicação
{
    internal class Calculo
    {

        //Var

        private int parc1 = 5; // 5%
        private int parc2 = 10; // 10%
        private int parc3 = 15; // 15%

        //Método

        public int MostrarPreco(int precoInicial, int tipoProduto)
        {
            int precoFinal = 0;
            

            switch (tipoProduto)
            {
                case 1:
                    precoFinal = precoInicial + (precoInicial * parc1 / 100);
                    break;

                case 2:
                    precoFinal = precoInicial + (precoInicial * parc2 / 100);
                    break;

                case 3:
                    precoFinal = precoInicial + (precoInicial * parc3 / 100);
                    break;

            }
            return precoFinal;
        }

    
    }
}
