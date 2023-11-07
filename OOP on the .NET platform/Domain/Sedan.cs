namespace HomeworkOOPOnThe.NETPlatform
{
    /// <summary>
    /// Sedan class is a derived class from carS.
    /// </summary>
    internal class Sedan : Car
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Sedan"/> class.
        /// </summary>
        /// <param name="brand">Used for storing type of brand of the cars.</param>
        /// <param name="model">Used for storing type of model of the cars.</param>
        /// <param name="year">Used for storing year of manufacture of the cars.</param>
        /// <param name="color">Used for storing color of the cars.</param>
        /// <param name="cost">Used for storing price of the cars.</param>
        /// <param name="typeOfCar">Used for storing the type of the cars.</param>
        /// <param name="numSeats">Used for storing the number of seats in sedan types of cars.</param>
        public Sedan(string brand, string model, int year, string color, double cost, TypeOfCar typeOfCar, int numSeats)
            : base(brand, model, year, color, cost, typeOfCar)
        {
            NumSeats = numSeats;
        }

        /// <summary>
        /// Gets or sets the car's numbers of seats in Sedans'.
        /// </summary>
        public int NumSeats { get; set; }

        /// <summary>
        /// Prints the details of a car to the console.
        /// </summary>
        /// <param name="car">The car whose details will be printed.</param>
        public override void PrintCarDetails(Car car)
        {
            if (car is Sedan sedan)
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Cost: {car.Cost}, Type: {car.TypeOfCar}, Number of Seats: {sedan.NumSeats}");
            }
            else
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Cost: {car.Cost}, Type: {car.TypeOfCar}");
            }
        }
    }
}
