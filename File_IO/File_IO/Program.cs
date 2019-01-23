using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = (Console.ReadLine());
            

            File.WriteAllText(@"C:\Users\Brenden\logs\logs.txt", input);
            Console.WriteLine(input);
            Console.ReadLine();

        }
    }
}
