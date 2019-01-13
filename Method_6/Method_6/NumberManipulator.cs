using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_6
{
    public class NumberManipulator
    {
        public int DivideTwoNumbers(int x)
        {
            return x / 2;
        }

        public int DivideTwoNumber(int x=4, int y=7)
        {
            return x + y;
        }

       public int outPutNumbers(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());

            return x + y;
        }
    }
}
