using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct__Drill
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Hello " + firstName + lastName);
            Console.ReadLine();
        }
    }
}
