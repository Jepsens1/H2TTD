using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2Automat;
using Xunit;

namespace AutomatUnit.Test
{
    public class WithdrawTest
    {
        [Fact]
        public void TestIfWithdrawWorks()
        {
            //Arrange
            Account account = new Account();
            Machine machine = new Machine();
            machine.InsertCard(account.Card);

            double expect = 50;
            //Act
            double actual = machine.Withdraw(50, account.Card.PinCode);
            //Asser
            Assert.Equal(expect, actual);
        }
    }
}
