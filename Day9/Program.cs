using System;
using System.Collections.Generic;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car volvo = new Car("Volvo", "S60", "Brown", 2007, 5700);
            Car bmw = new Car("BMW", "X5", "Black", 2014, 33500);
            List<Car> carList = new List<Car>();
            carList.Add(volvo);
            carList.Add(bmw);

            foreach (Car car in carList)
            {

            }
        }
    }
}
