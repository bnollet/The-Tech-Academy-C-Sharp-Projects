using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            a.FirstName = "Sample ";
            a.LastName = "Student";
            a.SayName();
            Console.ReadLine();
            
        }
    }
}
