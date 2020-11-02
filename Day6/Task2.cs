using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Task2
    { 

        public static string PrintMyName (string name)
        {

            string nameLetter = name.Substring(0,1);
            var final = nameLetter;
            Console.Write($"{final.ToUpper()}.");
            return final;

        }

        public static string PrintMySurname(string surename)
        {
            string lastName = surename.Substring(0,1);
            var final = lastName.ToUpper() + surename.Substring(1).ToLower();
            Console.Write(final);
            return final;
        }
    }
}
