using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Motorbike : Vehicle
    {
        public string type;
        public static int numberOfMotorbikes = 0;

        public Motorbike(string make, string model, float price) : base(make, model, price)
        {
            this.type = "Motorbike";
            numberOfMotorbikes++;
        }

        public static int getTotal()
        {
            return numberOfMotorbikes;
        }

        public string vehicleToString()
        {
            return this.type + "\t" + this.make + "\t " + this.model + "\t" + this.price;
        }
    }
}
