using System;

namespace RigsCodingSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int switchIndex = Convert.ToInt32(userInput);

            switch (switchIndex)
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

                default:
                    Console.WriteLine("Please enter number tu execute task.");
                    break;
            }
        }

        static void Task1()
        {

            string name = "Ivars";
            string lastName = "Rugelis";

            Console.WriteLine(name + lastName);

        }

        static void Task2()
        {
            int number;
            double dbNumber = 2.189;
            bool boolean = true;
            string stringType;

            number = 5;
            stringType = "Ivars";

            Console.WriteLine($"{number}, {dbNumber}, {boolean}, {stringType}");
        }

        static void Task3()
        {

            int x = 10;
            int y = 15;
            int z = x + y;

            Console.WriteLine(z);
        }

        static void Task4()
        {
            string usreInput = Console.ReadLine();

            Console.WriteLine(usreInput);
        }

        static void Task5()
        {

            string userName = Console.ReadLine();
            string userLastName = Console.ReadLine();

            string nameLetter = userName.Substring(0, 1);
            string lastNameLetter = userLastName.Substring(0, 1);

            Console.WriteLine($"{ nameLetter.ToUpper() + userName.Substring(1) }.{lastNameLetter.ToUpper() + userLastName.Substring(1)}");
            Console.WriteLine($"{nameLetter.ToUpper()} . {userLastName}");
        }

        static void Task6()
        {

            var userName = Console.Read();
            var userNumber = Console.Read();

            var fromString = userName;
            var fromInt = userNumber;


            userName = fromInt;
            userNumber = fromString;

            Console.WriteLine($"user name {userName} , user Number {userNumber}");

        }
    }
}
