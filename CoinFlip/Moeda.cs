using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    internal class Moeda
    {
        private string lado;

        public Moeda(string Lado)
        {
            lado = Lado;
        }

        public string Jogar()
        {
            int Result = new Random().Next(2);
            if (Result == 0)
            {
                if (lado == "Cara")
                {
                    return "Parabéns! Você escolheu Cara e a moeda deu Cara!";
                }
                else
                {
                    return "Que pena! Você escolheu Coroa, mas a moeda deu Cara!";
                }
            }
            else
            {
                if (lado == "Coroa")
                {
                    return "Parabéns! Você escolheu Coroa e a moeda deu Coroa!";
                }
                else
                {
                    return "Que pena! Você escolheu Cara, mas a moeda deu Coroa";
                }
            }
        }
    }
}
