using System;

namespace AirplaneApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("The name of Aircraft: Boeing-55");
            Airplane airplane = new Airplane(rnd.Next(1, 10), 5000, 50000, 100);
            Passenger passenger = new Passenger();
            
            Console.WriteLine("\nThe Information about passengers");
            airplane.addPassenger(passenger);
            airplane.cruise(rnd.Next(300, 5000));

            Console.WriteLine("\nThank you all for chosing us");
            Console.ReadKey();

        }
    }
}
