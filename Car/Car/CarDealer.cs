using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class CarDealer
    {
        public static int idCounter = 0;
        public string dealerName;
        public int id;
        public Dictionary<int, Vehicle> carDict = new Dictionary<int, Vehicle>();
        public List<Vehicle> soldCarsList = new List<Vehicle>();

        public CarDealer(string dealerName)
        {
            this.dealerName = dealerName;
        }


        public void addGivenCar(Vehicle car)
        {
            carDict.Add(id = idCounter++, car);
        }


        public void addNewCar()
        {
            string make = "";
            string model = "";
            float price = 0;

            Console.WriteLine("\n To add car, please give following details: ");
            Console.WriteLine("Make: : ");
            make = Console.ReadLine();
            Console.WriteLine("Model: : ");
            model = Console.ReadLine();
            Console.WriteLine("Price: : ");
            price = Convert.ToSingle(Console.ReadLine());
            Car car = new Car(make, model, price);
            carDict.Add(id = idCounter++, car);
            Console.WriteLine("The car has been successfully created: " + car.vehicleToString());
            this.displayAllCurrentCars();
        }


        public void displayCarById()
        {
            Console.WriteLine("Please enter id of car you wish to check");
            int id = Convert.ToInt32(Console.ReadLine());
            Vehicle carToCheck = null;
            bool success = carDict.TryGetValue(id, out carToCheck);
            if (success)
            {
                Console.WriteLine("Car of id:{0} found and its description is {1}", id, carToCheck.vehicleToString());
            }
            else
            {
                Console.WriteLine("Could not find car of id:{0}", id);
            }
        }


        public bool displayCarByName()
        {
            Console.WriteLine("Please enter name of car you wish to check");
            string make = Console.ReadLine();
            Vehicle carToCheck = null;
            bool success = false;
            foreach (KeyValuePair<int, Vehicle> car in carDict)
            {
                if (car.Value.make.ToLower() == make.ToLower())
                {
                    Console.WriteLine("Car of id:{0} found and its description is {1}", id, carToCheck.vehicleToString());
                    success = true;
                    return (success);
                }
            }
            return success;
        }


        public void toSoldCarById(int id)
        {
            Vehicle carToRemove = null;
            bool success = carDict.TryGetValue(id, out carToRemove);
            if (success)
            {
                carDict.Remove(id);
                Console.WriteLine("Car of id:{0} & description {1} removed", id, carToRemove.vehicleToString());
                this.displayAllCurrentCars();
            }
            else
            {
                Console.WriteLine("Could not find car of id:{0}", id);
            }
        }


        public void toSoldCar()
        {
            Console.WriteLine("Please enter id of car you wish to remove");
            int id = Convert.ToInt32(Console.ReadLine());
            Vehicle carToRemove = null;
            bool success = carDict.TryGetValue(id, out carToRemove);
            if (success)
            {
                carDict.Remove(id);
                Console.WriteLine("Car of id:{0} & description {1} removed", id, carToRemove.vehicleToString());
                soldCarsList.Add(carToRemove);
                this.displayAllCurrentCars();
            }
            else
            {
                Console.WriteLine("Could not find car of id:{0}", id);
            }
        }


        public int getCurrentCarStockTotal()
        {
            return carDict.Count();
        }


        public void displayCurrentVehicleStockTotal()
        {
            int carCount = carDict.Count();
            Console.WriteLine((carCount == 0) ? "\n Currently there is not stock" : "\n The total Vehicle stock we are holding is: {0} ", carCount);
        }


        public void displayCurrentCarStockTotal()
        {
            int carCount = Car.getTotal();
            Console.WriteLine((carCount == 0) ? "\n Currently there is not stock" : "\n The total Car stock we are holding is: {0} ", carCount);
        }


        public void displayCurrentMotorbikeStockTotal()
        {
            int motorbikeCount = Motorbike.getTotal();
            Console.WriteLine((motorbikeCount == 0) ? "\n Currently there is not stock" : "\n The total Motorbikestock we are holding is: {0} ", motorbikeCount);
        }


        public void displayAllCarStockTotal()
        {
            int carDictCount = carDict.Count();
            int carSoldCount = soldCarsList.Count();
            int carCount = carDictCount + carSoldCount;

            Console.WriteLine((carCount == 0) ? "\n Currently there is not stock" : "\n The total stock we have held since inception is: {0} ", carCount);
        }


        public void displayAllCurrentCars()
        {
            Console.WriteLine("\nThe current stock of available cars in our garage: ");
            foreach (KeyValuePair<int, Vehicle> car in carDict)
            {
                Console.WriteLine("Car ID: {0}, \t Car Details: {1}", car.Key, car.Value.vehicleToString());
            }

        }


        public void displayAllSoldCars()
        {
            Console.WriteLine("\nThe details of all cars sold by our garage: ");
            for (int i = 0; i < soldCarsList.Count(); i++)
            {
                Console.WriteLine("Car Details: {0}", soldCarsList[i].vehicleToString());
            }

        }


        public void displayCurrentStockValue()
        {
            Console.WriteLine("\nThe value of current stock is: ");
            float totalValue = 0;
            foreach (KeyValuePair<int, Vehicle> car in carDict)
            {
                totalValue = totalValue + car.Value.price;
            }
            Console.WriteLine("Total Car Value is {0}", totalValue);
        }
    }
}
