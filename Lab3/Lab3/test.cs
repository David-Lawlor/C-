using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class test
    {
        public static void Main()
        {
            List<IHasVolume> spheres = new List<IHasVolume>();
            spheres.Add(new Sphere(7));
            spheres.Add(new Sphere(8));

            foreach (Sphere s in spheres)
            {
                Console.WriteLine(s.ToString());
            }

            Console.ReadLine();
        }
    }
}
