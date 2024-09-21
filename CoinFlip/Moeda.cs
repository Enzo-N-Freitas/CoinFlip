using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    internal class Moeda
    {
        private int lado;

        public Moeda(int Lado)
        {
            lado = Lado;
        }

        public string Jogar()
        {
            int Result = new Random().Next(0, 2);
            if (Result == lado)
            {
                return "Você venceu";
            }
            else
            {
                return "Você perdeu";
            }
        }
    }
}
