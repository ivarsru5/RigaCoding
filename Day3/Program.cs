using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter task number to execute: ");
            string inputData = Console.ReadLine();
            int userData = Convert.ToInt32(inputData);

            switch (userData)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 7:
                    Task7();
                    break;
                case 8:
                    Task8();
                    break;
                case 9:
                    Task9();
                    break;
                default:
                    Console.WriteLine("Please enter valid taskNumber");
                    break;
            }
        }

        static void Task1()
        {

            int[] array = { 1, 6, 7, 78, 9, 9 };

            Console.WriteLine(string.Join(",", array));

        }

        static void Task2()
        {
            Console.WriteLine("Please awnser with true/false if you want dinner.");
            string userInput = Console.ReadLine();

            if (userInput == "True")
            {
                Console.WriteLine("Your dinner is ready");
            }
            else if (userInput == "False")
            {
                bool awnser = bool.Parse(userInput);
                Console.WriteLine($"You wont have dinner because your awnser was {awnser}");
            }
        }

        static void Task3()
        {

            bool data = true;
            int number = 0;

            while (data == true && number != 20)
            {
                number++;
                Console.WriteLine($"Bool value is: {data}");
                if (number == 20)
                {
                    data = false;
                    Console.WriteLine($"Bool value is: {data}");
                }
            }
        }

        static void Task4()
        {
            Console.WriteLine("Please enter how many times you want to print (Hello World)");
            string userInput = Console.ReadLine();
            int data = int.Parse(userInput);

            for (int index = 0; index != data; index++)
            {
                Console.WriteLine("Hello World");
            }
        }

        static void Task5()
        {
            int[] array = { 100, 200, 233, 66, 77, 98 };

            Console.WriteLine(array[0]);
            Console.WriteLine(array[5]);
        }

        static void Task6()
        {
            int[] array = { 7, 4, 7, 3, 6, 9, 2 };

            Console.WriteLine(array[3]);
            array[3] = 10;
            Console.WriteLine(array[3]);
        }

        static void Task7()
        {
            string[] names = { "Jānis", "Pēteris", "Andris" };

            Console.WriteLine($"Name is: {names[1]}");
            names[2] = "Jēkabs";
            for (int index = 0; index != names.Length; index++)
            {
                Console.WriteLine(names[index]);
            }
        }

        static void Task8()
        {
            var day = (weekDay)4;
            Console.WriteLine(day);
        }

        static void Task9()
        {
            string userData = Console.ReadLine();
            int number = Convert.ToInt32(userData);

            if (number <= 20)
            {

            }
        }

        enum weekDay
        {

            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
    }
}
