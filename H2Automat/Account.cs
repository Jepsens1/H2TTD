using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Automat
{
    public class Account
    {
        public Card Card { get; set; }

        public Account()
        {
            Card = new Card("1234", 50, "Visa", "4040202060608080");
        }
    }
}
