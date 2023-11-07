namespace HomeworkOOPOnThe.NETPlatform
{
    /// <summary>
    /// Our program.cs.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Our entry point.
        /// </summary>
        public static void Main()
        {
            TaxiDepot depot = new TaxiDepot(10);

            Sedan honda = new Sedan("Honda", "Civic", 2019, "Black", 25000, TypeOfCar.Sedan, 5);
            Sedan mitsubishi = new Sedan("Mitsubishi", "Lancer", 2022, "White", 30000, TypeOfCar.Sedan, 5);
            SUV audi = new SUV("Audi", "Q3", 2020, "Red", 50000, TypeOfCar.SUV, false);
            SUV bmw = new SUV("BWM", "X3", 2023, "Blue", 60000, TypeOfCar.SUV, true);
            Van chevrolet = new Van("Chevrolet", "Uplander", 2017, "Yellow", 43000, TypeOfCar.Van, 6);
            Van peugeout = new Van("Peugeout", "Partner", 2021, "White", 65000, TypeOfCar.Van, 6);

            depot.AddCar(honda);
            depot.AddCar(mitsubishi);
            depot.AddCar(audi);
            depot.AddCar(bmw);
            depot.AddCar(chevrolet);
            depot.AddCar(peugeout);

            Console.WriteLine("\nCars sorted by year: ");
            Car[] sortedResults = depot.SortByYear();

            foreach (var car in sortedResults)
            {
                car.PrintCarDetails(car);
            }

            Console.WriteLine($"The total cost of cars are: {depot.CalculateTotalCostOfCars()}");
            Car[] searchResultsType = depot.SearchByType(TypeOfCar.Sedan);
            Console.WriteLine("\nSearch results by type: ");

            if (searchResultsType != null)
            {
                foreach (var car in searchResultsType)
                {
                    car.PrintCarDetails(car);
                }
            }
            else
            {
                Console.WriteLine("No cars found with specified type.");
            }

            Console.WriteLine("\nSearch results by cost: ");
            Car[] searchResultsByCost = depot.SearchByCost(1000, 50000);

            foreach (var car in searchResultsByCost)
            {
                car.PrintCarDetails(car);
            }
        }
    }
}