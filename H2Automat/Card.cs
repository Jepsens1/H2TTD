using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Automat
{
    public class Card
    {
        public string PinCode { get; private set; }
        public double Balance { get; set; }
        public string CardName { get; private set; }
        public string CardNumber { get; private set; }

        public Card(string code, double balance, string name, string number)
        {
            PinCode = code;
            Balance = balance;
            CardName = name;
            CardNumber = number;
        }
    }
}
