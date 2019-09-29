using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW4
{
    public class Money
    {
        private string _denomination;
        private int _cash;

        public int Cash
        {
            get
            {
                return _cash;
            }
        }

        public Money() { }

        public Money(string denomination, int cash)
        {
            _denomination = denomination;
            _cash = cash;
        }

        public void Show()
        {
            Console.WriteLine($"Номинал: {_denomination}; Кол-во денег: {Cash}");
        }

        public bool IsEnough(int productCost)
        {
            if (Cash >= productCost)
            {
                return true;
            }
            return false;
        }

        public int HowMuch(int productCost)
        {
            return Cash / productCost;
        }
    }
}
