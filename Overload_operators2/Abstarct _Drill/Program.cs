using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct__Drill
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Employee a = new Employee();
            //a.firstName = ("Sample ");
            //a.lastName = ("Student ");
            //a.SayName();

            //IQuittable b = new Employee();
            //b.Quit();

            //Employee one = new Employee();
            //one.ID = 1;


            //Employee two = new Employee();
            //two.ID = 2;

            Employee<string> Things = new Employee<string>();
            Employee<int> Things2 = new Employee<int>();
            Things.things = new List<string> { "car", "bike", "bottle" };
            Things2.things = new List<int> { 1, 2, 3 };

            foreach ( string things in Things.things)
            { 
                Console.WriteLine(things);
            }

            foreach (int things in Things2.things)
            {
                Console.WriteLine(things);
            }
            Console.ReadLine();
            }


        }
    }

