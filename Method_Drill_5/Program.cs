using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Drill_5
{
    class Program
    {
        public class MethodParameters
        {
            static void Main()
            {
                Addition a = new Addition();
                Console.WriteLine("Pick a number ");
                int userInput1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("If you like to, please pick another number ");
                string userInput2 = Console.ReadLine();


                if (Int32.TryParse(userInput2, out int result))
                         {
                             int x = a.AddTwoNumbers(userInput1, result);
                             Console.WriteLine(x);
                        }
                       else 
                         {
                            int y = a.AddTwoNumbers(userInput1);
                            Console.WriteLine(y);
                        }
                Console.ReadLine();
             }

                //        }
                



                //Console.WriteLine(x);
                //Console.ReadLine();




                //bool success = Int32.TryParse(x,y)
                //if success = true

            }
        }
       
    }

