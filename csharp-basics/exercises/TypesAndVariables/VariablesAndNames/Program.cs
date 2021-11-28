using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars;
            int drivers;
            int passengers;
            int carsNotdriven; 
            int carsDriven;
            double seatsInAcar;
            double carpoolCapacity; 
            int averagePassengersPerCar;

            cars = 100; //cars
            seatsInAcar = 4.0; //seats in a car
            drivers = 28; // drivers
            passengers = 90; // passengers
            carsNotdriven = 0;  // free cars
            carsDriven = 1 ; // cars driven at the moment
            carpoolCapacity =  (passengers + drivers)/seatsInAcar;// carpool capacity
            averagePassengersPerCar = cars / passengers; // average passengers per car

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotdriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}