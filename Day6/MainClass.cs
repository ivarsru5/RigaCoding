using System;

namespace Day6
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number to execute task!");
            int taskNumber = Convert.ToInt32(Console.ReadLine());

            switch (taskNumber)
            {
                case 1:
                    Task1.PrintGreetings();
                    Task1.PrintGreetings();
                    Task1.PrintGreetings();
                    break;
                case 2:
                    Console.WriteLine("Please enter your Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter your Last Name: ");
                    string sureName = Console.ReadLine();

                    Console.WriteLine("Hello Mr/ Mrs: ");
                    Task2.PrintMyName(name, sureName);

                    break;
                default:
                    Console.WriteLine("Looks like number is out of task numbers range!");
                    break;
            }
        }
    }
}
