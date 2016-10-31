using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(20, Currency.Eur);
            Money n = new Money(20, Currency.USD);
            Money o = new Money(20, Currency.Yen);

            Console.WriteLine(m.Amount + "    " + m.Currency);
            Console.WriteLine(n.Amount + "    " + n.Currency);
            Console.WriteLine(o.Amount + "    " + o.Currency);

            m += n; 

            Console.WriteLine(m.Amount + "    " + m.Currency);
            Console.WriteLine(n.Amount + "    " + n.Currency);
            Console.WriteLine(o.Amount + "    " + o.Currency);

            Console.ReadLine();
        }
    }
}
