using System;
using System.Collections.Generic;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number to make array size: ");
            int lenght = Convert.ToInt32(Console.ReadLine());

            int[] userArray = new int[lenght];

            for (int index = 0; index < userArray.Length; index++)
            {
                Console.WriteLine("Please enter number to add: ");
                userArray[index] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(String.Join(",", Task1.GetOnlySmallValue(userArray)));
        }
    }
}
