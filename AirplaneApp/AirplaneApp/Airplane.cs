using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneApp
{
    internal class Airplane:FuelTank
    {
        private double fuelConsumption;

        public string Model { get; set; }
        public int PassengerCapacity { get; set; }
        public List<Passenger> Passengers { get; set; }
        public double Range { get; set; }
        public FuelTank Tank { get; set; }
        

        public Airplane(int passengerCapacity, double range, int capacity, double level) : base(capacity, level)
        {
            PassengerCapacity = passengerCapacity;
            Range = range;
            Capacity = capacity;
            Level = level;
            
        }
        
        private void addFuel(double liters)
        {
            Random rnd = new Random();
            int currentFuelLevel = rnd.Next(100, 50000);
            double kilometers = fuelConsumption / 10.0;

            if (currentFuelLevel < fuelConsumption)
            {
                double extraFuel = fuelConsumption - currentFuelLevel;
                Console.WriteLine("The: {0} liters is added, because destination place is {1} km for that we need minimum: " +
                    "{2} litters as we had {3} liters which was not enough", extraFuel, kilometers, fuelConsumption, currentFuelLevel);
                Console.WriteLine("\n0 liters of fuel remained after landing");
            }
            else
            {
                Console.WriteLine("We have: {0} liters currently which is more than fuel consumption which is: {1}" +
                    " liters as our destination place is {2} km", currentFuelLevel, fuelConsumption, kilometers);
                Console.WriteLine("\n{0} liters of fuel remained after landing", currentFuelLevel-fuelConsumption);
            }
            /*
            if (liters >= 50000)
            {
                Tank.Capacity = ((int)liters);
                Console.WriteLine("Stop refilling, it's already full");
            } */
           
        }
        public void addPassenger(Passenger passenger)
        {
            RandomPassenger randomPassenger = new RandomPassenger();
            for(int i=0; i<10; i++)
            {
                passenger = randomPassenger.generatePassenger();
                Console.WriteLine("=================");
                Console.WriteLine("Passenger's information");
                Console.WriteLine("Full name: {0} {1}\n\rGender: {2}\n\rAge:{3}\n\rTravelID:{4}",
                    passenger.FirstName, passenger.LastName, passenger.Gender, passenger.Age, passenger.TravelID);
                Console.WriteLine("=================");
                Console.WriteLine();
            }
           
        }
        public void cruise(double kilometers)
        {
            fuelConsumption = kilometers * 10.0;
            addFuel(fuelConsumption);
            
        }
        public void removePassenger(Passenger passenger)
        {

        }
    }
}
