using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Task3
    {

        public static string GetNameSureName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your surename: ");
            string surename = Console.ReadLine();

            string result = name + " " + surename;
            return result;
        }

        public static void PrintNameSureName()
        {
            Console.WriteLine(GetNameSureName());   
        }

    }
}
    