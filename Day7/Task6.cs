using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task6
    {

        public static void ValidatePersonId(string personId)
        {
            string firstPart = personId.Substring(0,6);
            string middlePart = personId.Substring(6, 1);
            string finalPart = personId.Substring(7);

            if (firstPart.Length == 6)
            {
                if (middlePart.Equals("-"))
                {
                    if (finalPart.Length == 5)
                    {
                        Console.WriteLine($"Your personal ID number is: {personId}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter valid ID number");
            }
        }

        public static void PrintBirthday(string personIdData)
        {
            string day = personIdData.Substring(0,2);
            string month = personIdData.Substring(2,2);
            string year = personIdData.Substring(4, 2);
        }
    }
}
