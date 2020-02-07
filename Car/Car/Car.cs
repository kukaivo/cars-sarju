using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{

    class Car:Vehicle
    {
        public string type;
        public static int numberOfCars;

        public Car(string make, string model, float price) : base (make, model, price)
        {
            this.type = "Car";
            numberOfCars++;
        }

        public static int getTotal()
        {
            return numberOfCars;
        }

        public string vehicleToString()
        {
            return this.type + "\t" + this.make + "\t " + this.model + "\t" + this.price;
        }
    }
}
