using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Addition a = new Addition();
                int x = a.AddTwoValues(12, 13);

                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
