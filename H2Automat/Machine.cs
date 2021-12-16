using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Automat
{
    public class Machine
    {
        Validate validate;
        Card card1;
        public Machine()
        {
            validate = new Validate();
        }
        public void InsertCard(Card card)
        {
            card1 = card;
        }
        //Checks to see if balance is not more than card has, and checks to see if pin code is correct
        public double Withdraw(double Balance, string pininput)
        {
            if (Balance <= card1.Balance && validate.IsCardValid(card1.PinCode, pininput))
            {
                card1.Balance -= Balance;
                return Balance;
            }
            return 0;
        }
    }
}
