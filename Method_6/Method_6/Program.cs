﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CalculatorApplication
    {
        public class NumberManipulator
        {

        static void Main()
        {
            NumberManipulator a = new NumberManipulator();
            int userInput = Convert.ToInt32(Console.ReadLine());
            int solution1 = a.DivideTwoNumbers(userInput);
            int solution2 = a.DivideTwoNumbers(x, y);
            int solution3 = a.outPutNumbers(x, y);

            Console.WriteLine("the result is " + solution1);
            Console.WriteLine("The overload result is " + solution2);
            Console.WriteLine("the output result is " + solution3)
            Console.ReadLine();
        }
       


        //public void getValues(out int x, out int y)
        //{
        //    Console.WriteLine("Enter the first value: ");
        //    x = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Enter the second value: ");
        //    y = Convert.ToInt32(Console.ReadLine());
        //}
        //static void Main(string[] args)
        //    {
        //        NumberManipulator n = new NumberManipulator();

        //        /* local variable definition */
        //        int a, b;

        //        /* calling a function to get the values */
        //        n.getValues(out a, out b);

        //        Console.WriteLine("After method call, value of a : {0}", a);
        //        Console.WriteLine("After method call, value of b : {0}", b);
        //        Console.ReadLine();
        //    }
        }
    }

