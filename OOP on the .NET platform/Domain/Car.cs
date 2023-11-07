namespace HomeworkOOPOnThe.NETPlatform
{
    /// <summary>
    /// Car class.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="brand">Used for storing type of brand of the cars.</param>
        /// <param name="model">Used for storing type of model of the cars.</param>
        /// <param name="year">Used for storing year of manufacture of the cars.</param>
        /// <param name="color">Used for storing color of the cars.</param>
        /// <param name="cost">Used for storing price of the cars.</param>
        /// <param name="typeOfCar">Used for storing the type of the cars.</param>
        public Car(string brand, string model, int year, string color, double cost, TypeOfCar typeOfCar)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            Cost = cost;
            TypeOfCar = typeOfCar;
        }

        /// <summary>
        /// Gets or sets the car's brand.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets the car's model.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the car's year of manufacture.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the car's color.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the car's cost or price.
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Gets or sets the car's Type using enum.
        /// </summary>
        public TypeOfCar TypeOfCar { get; set; }

        /// <summary>
        /// Prints the details of a car to the console and it's overriden in derived classes.
        /// </summary>
        /// <param name="car">The car whose details will be printed.</param>
        public virtual void PrintCarDetails(Car car)
        {
            Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, Cost: {car.Cost}, Type: {car.TypeOfCar}");
        }
    }
}
