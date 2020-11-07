using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Day9
{
    class Car
    {

        string make;
        string model;
        string color;
        int year;
        int price;

        public Car(string make, string model, string color, int year, int price)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
            this.price = price;
        }

        public string GetString()
        {
            string year = Convert.ToString(this.year);
            string price = Convert.ToString(this.price);

            string result = this.make + "," + this.model + "," + this.color + "," + year + "," + price;
            Console.WriteLine(result);
            return result;
        }
    }
}
