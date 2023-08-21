using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
         public double AddNumber(double n1,double n2)
        {
            return n1 + n2;
        }
        public double SubtractNumber(double n1, double n2)
        {
            return n1 - n2;
        }
        public double MultiplicationNumber(double n1, double n2)
        {
            return n1 * n2;
        }
        public double DevitionNumber(double n1, double n2)
        {
            return n1 /  n2;
        }
    }
}
