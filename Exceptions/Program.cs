using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(8);

            Console.WriteLine("pick a number to divide the list numbers ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine( numbers[i] + " divided by your input equals: " + numbers[i] / input);
            }
            Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please pick another number besides 0 ");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please pick a number to divide by ");
            }
            finally
            {
                Console.ReadLine();
            }



        }
    }
}
