using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter task number to execute");

            string input = Console.ReadLine();
            int toInt = Convert.ToInt32(input);

            
            switch (toInt)
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
                default:
                    Console.WriteLine("The number you entered is out of range.");
                    break;
               
            }
        }

        static void Task1()
        {
            string[] names = { "Ivars", "Janis", "Martins" };

            foreach (string indexName in names)
            {
                Console.WriteLine($" Name is: {indexName}");
            }
        }

        static void Task2()
        {
            int[] numbers = { 1, 3, 4, 8, 0, 23 };
            Array.Sort(numbers);

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] <= 5)
                {
                    Console.WriteLine("This number is less then five: ");
                    Console.WriteLine(numbers[index]);
                }

                if (numbers[index] >= 5)
                {
                    Console.WriteLine("This number is greater then five: ");
                    Console.WriteLine(numbers[index]);
                }
            }
        }

        //Not finished
        static void Task3()
        {
            string[] names = { "Janis", "Aivars", "Egars", "Inguss", "Juris", "Agris" };
            string letter;

            Console.WriteLine("Names in array is: ");
            Console.Write(string.Join(",", names));

            foreach (string name in names)
            {
                letter = name.Substring(0,1);
                foreach (char silable in letter)
                {
                    if (silable.Equals('J'))
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }

        static void Task4()
        {
            int[] number = new int[10];

            for (int index = 0; index <= number.Length; index++)
            {
                
                Console.WriteLine("Array contains of numbers: ");
                Console.WriteLine(number[index] = index);
            }
        }

        static void Task5()
        {
            Console.WriteLine("Please write down some sentence: ");
            string source = Console.ReadLine();
            string[] separetor = { ",", " " }; ;
            string[] nameArray = source.Split(separetor, StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in nameArray)
            {
                Console.WriteLine(name);
            }
            for (int index = nameArray.Length; index < nameArray.Length; index++)
            {
                Console.WriteLine(nameArray[index]);
            }
        }
    }
}
