using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Days.DaysOfTheWeek daysEnum = new Days.DaysOfTheWeek();
            Console.WriteLine("Please Write your favorite day of the week");
            string input = Console.ReadLine();

            Days.DaysOfTheWeek daysEnum;
            try
            {
                if (input == "Monday")
                {
                    daysEnum = Days.DaysOfTheWeek.Monday;
                    Console.WriteLine("You picked" + daysEnum);
                }

                else if (input == "Tuesday")
                {
                    daysEnum = Days.DaysOfTheWeek.Tuesday;
                    Console.WriteLine("You picked" + daysEnum);
                }

                else if (input == "Wednesday")
                {
                    daysEnum = Days.DaysOfTheWeek.Wednesday;
                    Console.WriteLine("You picked" + daysEnum);
                }

                else if (input == "Thursday")
                {
                    daysEnum = Days.DaysOfTheWeek.Thursday;
                    Console.WriteLine("You picked" + daysEnum);
                }

                else if (input == "Friday")
                {
                    daysEnum = Days.DaysOfTheWeek.Friday;
                    Console.WriteLine("You picked" + daysEnum);
                }

                else if (input == "Saturday")
                {
                    daysEnum = Days.DaysOfTheWeek.Saturday;
                    Console.WriteLine("You picked" + daysEnum);
                }

                else if (input == "Sunday")
                {
                    daysEnum = Days.DaysOfTheWeek.Sunday;
                    Console.WriteLine("You picked" + daysEnum);
                }
            }

            catch
            {
                else
                {

                    Console.WriteLine("Please enter an actual day of the week. ");
                }
            }

            Console.ReadLine();
            
        }

           
    }
}
