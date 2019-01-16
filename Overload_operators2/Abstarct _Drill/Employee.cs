using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct__Drill
{
    public class Employee<T> //: Person, IQuittable
    {
        //public override void SayName()
        //{
        //    Console.WriteLine("Hello " + firstName + lastName);
        //    Console.ReadLine();
        //}
        //public void Quit()
        //{
        //    Console.WriteLine("Hello there! ");
        //    Console.ReadLine();
        //}

        public List<T> things { get; set; }



        //public int ID { get; set; }

        //public static bool operator==(Employee one, Employee two)
        //{
        //    return (one == two);
        //}
        //public static bool operator !=(Employee one, Employee two)
        //{
        //    return !(one == two);

        //}


    }
}
