using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter walid Task number: ");
            string data = Console.ReadLine();
            int taskNumber = Convert.ToInt32(data);

            switch (taskNumber)
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
                default:
                    Console.WriteLine("Please enter valid number to execute task");
                    break;
            }
        }

        static void Task1()
        {
            var firstNumber = Console.ReadLine();
            var secondNumber = Console.ReadLine();

            int parseFirst = Convert.ToInt32(firstNumber);
            int parseSecond = Convert.ToInt32(secondNumber);

            if (parseFirst >= 0 && parseFirst <= 20 && parseSecond >= 30 && parseSecond <= 50)
            {
                Console.WriteLine($"Number: {parseFirst} and number: {parseSecond} summ is {parseFirst + parseSecond}");
            }
            else
            {
                Console.WriteLine("Please enter first number in range 0 to 20");
                Console.WriteLine("Please enter second number in range 30 to 50");
            }
        }

        static void Task2()
        {
            string houseObject = Console.ReadLine();

            string objectLetter = houseObject.Substring(0, 1);

            if (objectLetter == "a" || objectLetter == "c" || objectLetter == "d" || objectLetter == "e")
            {
                Console.WriteLine($"{houseObject} is going to be placed in first floor!");
            }
            else if (objectLetter == "f" || objectLetter == "g" || objectLetter == "h" || objectLetter == "i")
            {
                Console.WriteLine($"{houseObject} is going to be placed in second floor!");
            }
            else if (objectLetter == "j" || objectLetter == "k" || objectLetter == "l" || objectLetter == "m")
            {
                Console.WriteLine($"{houseObject} is going to be placed in third floor!");
            }
            else if (objectLetter == "n" || objectLetter == "o" || objectLetter == "p" || objectLetter == "r")
            {
                Console.WriteLine($"{houseObject} is going to be placed in forth floor!");
            }
            else if (objectLetter == "o" || objectLetter == "s" || objectLetter == "t" || objectLetter == "u")
            {
                Console.WriteLine($"{houseObject} is going to be placed in fifth floor!");
            }
            else
            {
                Console.WriteLine($"{houseObject} is going to be placed in basemant!");
            }
        }

        static void Task3()
        {
            Console.WriteLine("Please type in spruce type - regular : silver");
            string spruceType = Console.ReadLine();
            Console.WriteLine("Please enter height of spruce");
            string spruceHeight = Console.ReadLine();
            Console.WriteLine("Please enter spruce diameter");
            string spruceDiameter = Console.ReadLine();

            int height = Convert.ToInt32(spruceHeight);
            int diameter = Convert.ToInt32(spruceDiameter);



            if (50 <= height && height < 100 && 100 <= diameter && diameter < 150 && spruceType == "regular")
            {
                Console.WriteLine("The spruce needs to be placed in first guest room.");
            }
            else if (100 <= height && height < 150 && 150 <= diameter && diameter < 200 && spruceType == "regular")
            {
                Console.WriteLine("The spruce needs to be placed in second guest room.");
            }
            else if (150 <= height && height < 300 && 200 <= diameter && diameter < 300 && spruceType == "regular" || spruceType == "silver")
            {
                Console.WriteLine("The spruce needs to be placed in fireplace hall.");
            }
            else
            {
                Console.WriteLine("Please enter valid spruce data to cauculete in witch room should be placed!");
            }
        }

        static void Task4()
        {
            Console.WriteLine("Please eneter first contastants name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter second contastants name: ");
            string secondName = Console.ReadLine();
            int[] firtsPlayer = new int[3];
            int[] secondPlayer = new int[3];

            if (firstName.Length > 0)
            {
                Console.WriteLine("Please enter your three numbers to cauculate result: ");
                for (int number = 0; number < firtsPlayer.Length; number++)
                {
                    string input = Console.ReadLine();
                    int toInt = Convert.ToInt32(input);
                    firtsPlayer[number] = toInt;
                    Console.WriteLine(Convert.ToString(firtsPlayer));
                }
            }

            if (secondName.Length > 0)
            {
                Console.WriteLine("Please enter your three numbers to cauculate result: ");
                for (int number = 0; number < secondPlayer.Length; number++)
                {
                    string input = Console.ReadLine();
                    int toInt = Convert.ToInt32(input);
                    secondPlayer[number] = toInt;

                }
            }
        }
    }
}