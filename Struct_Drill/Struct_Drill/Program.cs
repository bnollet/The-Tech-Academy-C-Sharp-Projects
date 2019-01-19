using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number1 = new Number();
            number1.Amount = 10;

            Console.WriteLine(number1.Amount);
            Console.ReadLine();
        }
    }
}
