using System;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how big you want the array.");
            var lenght = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[lenght];

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine("Please enter your arrays element.");
                array[index] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your arrays number is: {array[index]}");
            }

            Task1.GetOnlySmallValue(array);
        }
    }
}
