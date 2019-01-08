using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill
{
    class Program : SimpleMath
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please pick a number ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int addingResult = SimpleMath.AddTwoNumbers(userNumber);
            int subtractResult = SimpleMath.SubtractTwoNumbers(userNumber);
            int productResult = SimpleMath.MultiplyTwoNumbers(userNumber);

            Console.WriteLine("the adding result is " + addingResult);
            //Console.ReadLine();

            Console.WriteLine("the subtraction result is " + subtractResult);
            //Console.ReadLine();

            Console.WriteLine("the Multiplication result is " + productResult);
            Console.ReadLine();

      
        }
    }
}
