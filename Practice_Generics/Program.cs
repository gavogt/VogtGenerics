using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practice_Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greet the user
            DisplayHeader();

            // Init Lists
            var carList = new List<Vehicle<int, DateTime>>();
            var truckList = new List<Vehicle<double, int>>();

            // If they want to initialize a new vehicle, ask for time
            var vehicleOne = new Vehicle<int, DateTime>();
            vehicleOne.Make = "Ferrari";
            vehicleOne.Model = "488 GTB";
            vehicleOne.Type = "Car";
            vehicleOne.MPG = 22;
            vehicleOne.VehicleAquiredDate = new DateTime(2018, 8, 16);

            var vehicleTwo = new Vehicle<double, int>();
            vehicleTwo.Make = "Volvo";
            vehicleTwo.Model = "VNL64T430";
            vehicleTwo.Type = "Truck";
            vehicleTwo.MPG = 6.3;
            vehicleTwo.VehicleAquiredDate = 2018;

            // Loop here
            carList.Add(vehicleOne);
            truckList.Add(vehicleTwo);

            // If they want to display a car list or a truck list option
            foreach (var item in carList)
            {
                Console.WriteLine("Car make: " + item.Make);
                Console.WriteLine("Car model: " + item.Model);
                Console.WriteLine("Car MPG: " + item.MPG);
                Console.WriteLine("Car Aquired: " + ((DateTime)(item.VehicleAquiredDate)).ToShortDateString());

            }

            foreach (var item in truckList)
            {
                Console.WriteLine("");
                Console.WriteLine("Truck make: " + item.Make);
                Console.WriteLine("Truck model: " + item.Model);
                Console.WriteLine("Truck MPG: " + item.MPG);
                Console.WriteLine("Truck Aquired: " + item.VehicleAquiredDate);
            }

            Console.WriteLine("");
        }

        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            // cw snippet
            Console.WriteLine("\n****** WELCOME! ******\n");

            Console.ResetColor();

        }
    }
}
