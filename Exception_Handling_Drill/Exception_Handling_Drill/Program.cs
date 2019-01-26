using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello there, please enter your age ");
                int age = Convert.ToInt32(Console.ReadLine());
                int yearAge = 2019 - age;

                if (age > 0)
                {
                    Console.WriteLine("you were born in {0} ", yearAge);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please Enter a number greater than zero ");
                    int age1 = Convert.ToInt32(Console.ReadLine());
                    int yearAge1 = 2019 - age1;
                    Console.WriteLine("you were born in {0} ", yearAge1);
                }

               
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter a digit");
                int age = Convert.ToInt32(Console.ReadLine());
                int yearAge = 2019 - age;
                Console.WriteLine("you were born in {0} ", yearAge);
            }
            Console.ReadLine();






            //if (age < 0)
            //{
            //    try
            //    {
            //        bool validAnswer = false;
            //       // while (!validAnswer)
            //        //{
            //            validAnswer = int.TryParse(Console.ReadLine(), out age);
            //       // }
            //       // else 
            //        //{
            //            //Console.WriteLine("");
        }
                    

                }
            }

            



       

