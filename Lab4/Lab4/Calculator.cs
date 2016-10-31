using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Calculator
    {
        public static double Divide(double operand1, double operand2)
        {
            try
            {
                if (operand2 == 0)
                    throw new ArgumentException();
                else
                    return operand1 / operand2;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Cannot divide by 0");
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
