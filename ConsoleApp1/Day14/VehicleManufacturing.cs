using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day14
{

    public abstract class Vehicles
    {
        public abstract void Assemble(int parts);
        public abstract void TestDrive(double distance, double fuelUsed);
        public abstract void Deliver(double baseCost, double taxRate);

    }
    internal class Car :Vehicles
    {
        public override void Assemble(int parts)
        {
            Console.WriteLine($"The car has {parts} parts to assemble");
        }
        public override void TestDrive(double distance, double fuelUsed)
        {
            double mileage = distance / fuelUsed;
            Console.WriteLine($"The mileage of car is {mileage}");
        }
        public override void Deliver(double baseCost, double taxRate)
        {
            double totalCost=baseCost*(taxRate/100);
            Console.WriteLine($"The total cost of car with baseamount {baseCost} including {taxRate}% tax : {totalCost}");
        }
    }
    internal class Bike :Vehicles
    {
        public override void Assemble(int parts)
        {
            Console.WriteLine($"The Bike has {parts} parts to assemble");
        }
        public override void TestDrive(double distance, double fuelUsed)
        {
            double mileage = distance / fuelUsed;
            Console.WriteLine($"The mileage of Bike is {mileage}");
        }
        public override void Deliver(double baseCost, double taxRate)
        {
            double totalCost=baseCost*(taxRate/100);
            Console.WriteLine($"The total cost of Bike with baseamount {baseCost} including {taxRate}% tax : {totalCost}");
        }
    }
    internal class Truck :Vehicles
    {
        public override void Assemble(int parts)
        {
            Console.WriteLine($"The Truck has {parts} parts to assemble");
        }
        public override void TestDrive(double distance, double fuelUsed)
        {
            double mileage = distance / fuelUsed;
            Console.WriteLine($"The mileage of Truck is {mileage}");
        }
        public override void Deliver(double baseCost, double taxRate)
        {
            double totalCost=baseCost*(taxRate/100);
            Console.WriteLine($"The total cost of Truck with baseamount {baseCost} including {taxRate}% tax : {totalCost}");
        }
    }

    public class VehicleFactory
    {
        public static Vehicles GetVehicle(String vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "bike":
                    return new Bike();
                    
                case "car":
                    return new Car();
                    
                case "truck":
                   return new Truck();
                   
                default:
                    throw new ArgumentException("Invalid vehicle type");
                    
            }
        }
    }
}
