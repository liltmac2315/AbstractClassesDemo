﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> Vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var car1 = new Car()
            {
                HasTrunk = true,
                year = "2000",
                make = "Honda",
                model = "Accord",
            };
            var motorcycle1 = new Motorcycle() 
            { 
                HasSideCart = true,
                year = "2001",
                make = "Kawasaki",
                model = "Ninja"
            };
            Vehicle vehicle1 = new Car() 
            {
                year = "2020",
                make = "Tesla",
                model = "x"

            };   
            Vehicle vehicle2 = new Motorcycle()
            {
                year = "2010",
                make = "suzuki",
                model = "GSXR"


            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            Vehicles.Add(car1);
            Vehicles.Add(motorcycle1);
            Vehicles.Add(vehicle1);
            Vehicles.Add(vehicle2); 

            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine($"year: {vehicle.year}");
                Console.WriteLine($"make: {vehicle.make}");
                Console.WriteLine($"model:{vehicle.model}");
                Console.WriteLine();
                Console.WriteLine();
            }


            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
