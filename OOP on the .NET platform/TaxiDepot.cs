namespace HomeworkOOPOnThe.NETPlatform
{
    /// <summary>
    /// TaxiDepot class used for storing and manipulating the cars.
    /// </summary>
    internal class TaxiDepot
    {
        private Car[] cars;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxiDepot"/> class.
        /// </summary>
        /// <param name="size">Used for defining the size of array cars.</param>
        public TaxiDepot(int size)
        {
            cars = new Car[size];
        }

        /// <summary>
        /// AddCar method adds cars to our Car array
        /// <paramref name="carsToAdd"/>Used for taking the car that we want to add.
        /// </summary>
        public void AddCar(Car carToAdd)
        {
            int index = Array.IndexOf(cars, null);

            if (index >= 0)
            {
                cars[index] = carToAdd;
                Console.WriteLine($"Added car {carToAdd.Brand} {carToAdd.Model} to the depot.");
            }
            else
            {
                Console.WriteLine("Error: The depot is full and cannot accept more cars.");
            }
        }

        /// <summary>
        /// Searches for car based on the type.
        /// </summary>
        /// <param name="typeOfCarForSearch">The type of car to be processed.</param>
        /// <returns>An array of cars result based on type.</returns>
        public Car[] SearchByType(TypeOfCar typeOfCarForSearch)
        {
            Car[] matchingCars = new Car[cars.Length];
            int count = 0;

            foreach (var car in cars)
            {
                if (car != null && car.TypeOfCar == typeOfCarForSearch)
                {
                    matchingCars[count] = car;
                    count++;
                }
            }

            Array.Resize(ref matchingCars, count);
            return matchingCars;
        }

        /// <summary>
        /// Searches for car based on the type.
        /// </summary>
        /// <param name="minCost">The number for minimum cost to be processed.</param>
        /// <param name="maxCost">The number for maximum cost to be processed.</param>
        /// <returns>An array of result cars based on price.</returns>
        public Car[] SearchByCost(double minCost, double maxCost)
        {
            Car[] matchingCars = new Car[cars.Length];
            int count = 0;

            foreach (var car in cars)
            {
                if (car != null && car.Cost >= minCost && car.Cost <= maxCost)
                {
                    matchingCars[count] = car;
                    count++;
                }
            }

            Car[] result = new Car[count];
            Array.Copy(matchingCars, result, count);

            return result;
        }

        /// <summary>
        /// Sorts the cars by year in ascending order.
        /// </summary>
        /// <returns>An array of cars ordered by year.</returns>
        public Car[] SortByYear()
        {
            return cars.Where(c => c != null).OrderBy(c => c.Year).ToArray();
        }

        /// <summary>
        /// Calculates the total cost of all cars.
        /// </summary>
        /// <returns>A double of total cost.</returns>
        public double CalculateTotalCostOfCars()
        {
            double totalCost = 0;

            foreach (var car in cars)
            {
                if (car != null)
                {
                    totalCost += car.Cost;
                }
            }

            return totalCost;
        }
    }
}
