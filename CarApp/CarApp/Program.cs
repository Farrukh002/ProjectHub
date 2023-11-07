using System;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("My Car: ");
            Car myCar = new Car("Audi", "AA-AA-001", 5, 10);
            Car yourCar = new Car("Volvo", "VV-VV-001", 6, 12);
            Console.WriteLine(myCar.getBrand());
            Console.WriteLine(myCar.getLicensePlateNumber());
            Console.WriteLine(myCar.getStartinPositionX());
            Console.WriteLine(myCar.getStartinPositionY());

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Your Car: ");
            Console.WriteLine(yourCar.getBrand());
            Console.WriteLine(yourCar.getLicensePlateNumber());
            Console.WriteLine(yourCar.getStartinPositionX());
            Console.WriteLine(yourCar.getStartinPositionY());
            Console.ReadKey();
        }
    }
}
