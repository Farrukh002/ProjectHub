namespace HomeworkOOPOnThe.NETPlatform
{
    /// <summary>
    /// Van class is a derived class from car.
    /// </summary>
    internal class Van : Car
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Van"/> class.
        /// </summary>
        /// <param name="brand">Used for storing type of brand of the cars.</param>
        /// <param name="model">Used for storing type of model of the cars.</param>
        /// <param name="year">Used for storing year of manufacture of the cars.</param>
        /// <param name="color">Used for storing color of the cars.</param>
        /// <param name="cost">Used for storing price of the cars.</param>
        /// <param name="typeOfCar">Used for storing the type of the cars.</param>
        /// <param name="numDoors">Used for storing the number of doors in the Vans'.</param>
        public Van(string brand, string model, int year, string color, double cost, TypeOfCar typeOfCar, int numDoors)
            : base(brand, model, year, color, cost, typeOfCar)
        {
            NumDoors = numDoors;
        }

        /// <summary>
        /// Gets or sets the number of doors in Vans'.
        /// </summary>
        public int NumDoors { get; set; }

        /// <summary>
        /// Prints the details of a car to the console.
        /// </summary>
        /// <param name="car">The car whose details will be printed.</param>
        public override void PrintCarDetails(Car car)
        {
            if (car is Van van)
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color} Cost: {car.Cost}, Type: {car.TypeOfCar}, Number of Doors: {van.NumDoors}");
            }
            else
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color} Cost: {car.Cost}, Type: {car.TypeOfCar}");
            }
        }
    }
}
