using System;
using System.Linq;
using System.Linq.Expressions;

namespace Day7
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter task number to execute, remember ther is subTask as well, liek 1.1");
            string input = Convert.ToString(Console.ReadLine());

            switch (input)
            {
                case "1.1":
                    Console.WriteLine("Please enter your Name: ");
                    string name = Console.ReadLine();
                    PrintNameSureName(name);
                    break;

                case "1.2":
                    Console.WriteLine("Please enter your Name: ");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Please enter your Surename: ");
                    string surename = Console.ReadLine();
                    PrintNameSureName(userName, surename);
                    break;

                case "2.1":
                    Console.WriteLine("Please enter 5 numbers to add them to array and then print them:");
                    
                    int[] usersArray = new int[5];
                    for (int element = 0; element < usersArray.Length; element++)
                    {
                        usersArray[element] = Convert.ToInt32(Console.ReadLine());
                    }

                    PrintArrayValues(usersArray);
                    break;

                case "2.2":
                    Console.WriteLine("Please enter any kind of five names: ");
                    string[] strArray = new string[5];
                    for (int element = 0; element < strArray.Length; element++)
                    {
                        strArray[element] = Console.ReadLine();
                    }

                    PrintArrayValues(strArray);
                    break;

                case "3":
                    GetNonEmptyArray(blankSpaceArray);
                    break;
                case "4.1":
                    Console.WriteLine("Please enter Your personal ID Number to validate");
                    string idNumber = Console.ReadLine();
                    Task6.ValidatePersonId(idNumber);
                    break;
                default:
                    Console.WriteLine("Please enter walid task Number");
                    break;
            }
            
        }

        static void PrintNameSureName(string name)
        {
            Console.Write(name);
        }

        static void PrintNameSureName(string name, string surename)
        {
            Console.WriteLine($"Hello Mr/Mrs {name} {surename}");
        }

        static void PrintNameAge(string name, string age)
        {

            Console.WriteLine("Please enter your age: ");
            if (age == String.Empty)
            {
                Console.WriteLine("Users age is: 99");
            }
            else
            {
                int userAge = Convert.ToInt32(age);
                Console.WriteLine($"Users age is: {userAge}");
            }
        }

        static void PrintArrayValues(int[] array)
        {
            int index = 0;
            foreach (int element in array)
            {
                index++;
                Console.WriteLine($"For index {index} arrays element is {element}");
            }

        }

        static void PrintArrayValues(string[] strArray)
        {
            int index = 0;
            foreach (string element in strArray)
            {
                index++;
                Console.WriteLine($"For index {index} array element is ( {strArray} )");
            }
        }

        //MARK: - task 4
        static string[] blankSpaceArray = { "Jānis", "", "Pēteris", "", "Andris" };

        public static string[] GetNonEmptyArray(string[] array)
        {
            array = array.Where(blank => !string.IsNullOrEmpty(blank.Trim())).ToArray();
            return array;
        }
    }
}
