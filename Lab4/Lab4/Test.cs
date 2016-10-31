using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Test
    {
        static void Main()
        {
            /*
            try
            {
                Console.Write("Enter the first openand");
                double oper1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second operand");
                double oper2 = Double.Parse(Console.ReadLine());
                Console.WriteLine(Calculator.Divide(oper1, oper2));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + " FormatException");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message + " Overflowexception");
            }
            */

            ModuleCAResult module = new ModuleCAResult("Computing", 30, "Dave", new List<int> { 60, 60, 60 });
            Console.WriteLine(module.ToString());
            Console.WriteLine(module.GetResult(0));
            Console.WriteLine(module.GetResult(1));
            Console.WriteLine(module.GetResult(2));
            Console.WriteLine(module.GetResult(3));
            Console.WriteLine(module.GetResult(4));
            Console.ReadLine();
        }
    }
}
