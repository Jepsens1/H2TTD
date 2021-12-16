using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Automat
{
    public class Validate
    {
        public bool IsCardValid(string userinput, string pinnumber)
        {
            //Checks to see if pincode is okay
            if (userinput == pinnumber)
            {
                return true;
            }
            return false;
        }
    }
}
