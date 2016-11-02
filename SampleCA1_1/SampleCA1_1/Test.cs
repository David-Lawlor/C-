using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_1
{
    class Test
    {
        static void Main(string[] args)
        {
            CurrentAccount ca = new CurrentAccount("12ab", 100);

            ca.MakeDeposit(100);
            ca.MakeWithdrawal(500);
            ca.MakeDeposit(200);
            ca.MakeWithdrawal(150);

            Console.WriteLine(ca.ToString());

            Console.ReadLine();
        }
    }
}
