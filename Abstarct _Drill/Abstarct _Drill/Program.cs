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
            Employee a = new Employee();
            a.firstName = ("Sample ");
            a.lastName = ("Student ");
            a.SayName();
            Console.ReadLine();
        }
    }
}
