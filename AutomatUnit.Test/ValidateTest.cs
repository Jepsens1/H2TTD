using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2Automat;
using Xunit;

namespace AutomatUnit.Test
{
    public class ValidateTest
    {
        [Fact]
        public void TestIfCardPincodeIsValid()
        {
            //Arrange
            bool expect = true;
            //Act
            Validate validate = new Validate();
            bool actual = validate.IsCardValid("1234", "1234");
            //Assert
            Assert.Equal(expect, actual);
        }
    }
}
