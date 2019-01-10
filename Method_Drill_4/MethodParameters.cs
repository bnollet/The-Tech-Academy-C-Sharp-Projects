using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill_4
{
   
        public class Addition
        {
            public int AddTwoValues(int x, int y)
            {
                Console.WriteLine("the number is " + x);
                return x + y;
            }

            public int AddTwoValues(double x, double z)
            {
            return (int)(x * z);
            }

            public string AddTwoValues(string x, string z)
        {
            return (x + z);
                //(Convert.ToInt32(x)) + (Convert.ToInt32(z));
        }
        }
}
