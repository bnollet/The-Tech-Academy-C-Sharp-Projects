using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill_4
{
    class Program
    {
        public class MethodParameters
        {
            static void Main()
            {
                Addition a = new Addition();
                int x = a.AddTwoValues(12, 13);
                int y = a.AddTwoValues(12, 13.05);
                string z = a.AddTwoValues("two", "four");

                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
                Console.ReadLine();
            }
        }
    }
}
