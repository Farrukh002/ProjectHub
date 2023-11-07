namespace HomeworkOOPOnThe.NETPlatform
{
    /// <summary>
    /// Suv class is derived class from car.
    /// </summary>
    internal class SUV : Car
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SUV"/> class.
        /// </summary>
        /// <param name="brand">Used for storing type of brand of the cars.</param>
        /// <param name="model">Used for storing type of model of the cars.</param>
        /// <param name="year">Used for storing year of manufacture of the cars.</param>
        /// <param name="color">Used for storing color of the cars.</param>
        /// <param name="cost">Used for storing price of the cars.</param>
        /// <param name="typeOfCar">Used for storing the type of the cars.</param>
        /// <param name="hasThirdRow">Used for defining whether the SUVs' have the third row of seats or not.</param>
        public SUV(string brand, string model, int year, string color, double cost, TypeOfCar typeOfCar, bool hasThirdRow)
            : base(brand, model, year, color, cost, typeOfCar)
        {
            HasThirdRow = hasThirdRow;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the SUVs' have the third row of seats or not.
        /// </summary>
        public bool HasThirdRow { get; set; }

        /// <summary>
        /// Prints the details of a car to the console.
        /// </summary>
        /// <param name="car">The car whose details will be printed.</param>
        public override void PrintCarDetails(Car car)
        {
            if (car is SUV suv)
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Cost: {car.Cost}, Type: {car.TypeOfCar} It has third row: {suv.HasThirdRow}");
            }
            else
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Cost: {car.Cost}, Type: {car.TypeOfCar}");
            }
        }
    }
}
