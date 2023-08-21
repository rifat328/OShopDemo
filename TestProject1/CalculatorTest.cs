using CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class CalculatorTest :IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void TestAdd()
        {
            //Arrenge
            Calculator calAdd=new Calculator();
            double n1 = 20.5;
            double n2 = 20.4;
            double expected= n1 + n2;
            //Act
            double result= calAdd.AddNumber(n1 , n2);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2.0,2.4,4.4)]
        public void TestAdd2(double n1,double n2, double expected) {

            Calculator calAdd=new Calculator();
            //act
            double result = calAdd.AddNumber(n1,n2);
             //assert
            Assert.Equal(expected, result);
        
        }

        [Theory]
        [InlineData(2.0, 2.4, 4.4)]
        public void TestAdd3(double n1, double n2, double expected)
        {

            Calculator calAdd = new Calculator();
            //act
            double result = calAdd.AddNumber(n1, n2);
            //assert
            Assert.True(result == expected);

        }
    }
}
