using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Automat
{
    public class MachineManager
    {
        Machine machine = new Machine();
        Account account = new Account();

        public MachineManager()
        {
            machine = new Machine();
        }
        public void Withdraw()
        {
            InsertCard();
            Console.WriteLine("Type how much you would like to witdraw");
            string useramount = Console.ReadLine();
            Console.WriteLine("Type in pincode");
            string pincode = Console.ReadLine();
            if (machine.Withdraw(Convert.ToDouble(useramount), pincode) != 0)
            {
                Console.WriteLine($"You have withdrawed {useramount}");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
        void InsertCard()
        {
            machine.InsertCard(account.Card);
        }
    }
}
