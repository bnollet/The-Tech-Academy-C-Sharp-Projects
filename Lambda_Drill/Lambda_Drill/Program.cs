using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lambda_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee>Employees = new List<Employee>();
            Employees.Add(new Employee { firstName = "Tom", lastName = "Johnson", ID = 1 });
            Employees.Add(new Employee { firstName = "Joe", lastName = "Kinder", ID = 2 });
            Employees.Add(new Employee { firstName = "Elizabeth", lastName = "Nelson", ID = 3 });
            Employees.Add(new Employee { firstName = "Mary", lastName = "Blue", ID = 4 });
            Employees.Add(new Employee { firstName = "Peter", lastName = "Green", ID = 5 });
            Employees.Add(new Employee { firstName = "Jacob", lastName = "LaMont", ID = 6 });
            Employees.Add(new Employee { firstName = "Jacob", lastName = "LaMont", ID = 6 });
            Employees.Add(new Employee { firstName = "Josh", lastName = "Camel", ID = 7 });
            Employees.Add(new Employee { firstName = "Lious", lastName = "scratcher", ID = 8 });
            Employees.Add(new Employee { firstName = "john", lastName = "slack", ID = 9 });
            Employees.Add(new Employee { firstName = "Joe", lastName = "peterson", ID = 10 });

            List<Employee> Employees2 = new List<Employee>();


            foreach (Employee name in Employees)
            {
                if (name.firstName == "Joe")
                {
                    Employees2.Add(name);
                }
                else
                {
                    Console.WriteLine("not Joe");
                }
            }


            List<Employee> newList = Employees.Where(x => x.ID > 5).ToList();
            Console.ReadLine();


        } 

    }

    }


