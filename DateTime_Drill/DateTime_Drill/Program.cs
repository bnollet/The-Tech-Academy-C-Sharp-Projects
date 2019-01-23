using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Please type a number ");
            double x = Convert.ToDouble(Console.ReadLine());

            DateTime xHourslater = currentTime.AddHours(x);
            Console.WriteLine(xHourslater);

            Console.ReadLine();

            //private DateTime AddHours(double x);
           // public DateTime AddHours(double value);

            
        }
    }
}
