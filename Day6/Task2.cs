using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Task2
    { 

        public static void PrintMyName (string name, string surname)
        {
            string nameLetter = name.Substring(0,1);
            string sureNameLetter = surname.Substring(0,1);

            Console.WriteLine($"{nameLetter.ToUpper()}. ");
            Console.Write($"{sureNameLetter.ToUpper() + surname.Substring(1).ToLower()}");
        }

    }
}
