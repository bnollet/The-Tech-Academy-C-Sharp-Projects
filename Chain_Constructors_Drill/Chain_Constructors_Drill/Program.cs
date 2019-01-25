using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Constructors_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo a = new Foo(), b = new Foo(456, "def"), c = new Foo(123), d = new Foo("abc");

            var name = ("redman");
            const string realName = "Reggie";

            Console.WriteLine("He goes by {0} but his real name is {1} ", name, realName);
            Console.ReadLine();


        }
    }
}

