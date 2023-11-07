namespace ExceptionsDelegatesEvents
{
    /// <summary>
    /// Lane class.
    /// </summary>
    internal class Lane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lane"/> class.
        /// </summary>
        /// <param name="capacity">Used for storing the capacity of Lane.</param>
        public Lane(int capacity)
        {
            Capacity = capacity;
            Car = new List<Car>();
        }

        /// <summary>
        /// Gets the Lane's capacity.
        /// </summary>
        public int Capacity { get; }

        /// <summary>
        /// Gets the List of cars object.
        /// </summary>
        public List<Car> Car { get; }

        /// <summary>
        /// Event raised when a car enters a specified area.
        /// </summary>
        /// <remarks>
        /// This event is raised whenever a car enters a designated area or location.
        /// Subscribers can handle this event to perform specific actions when a car enters the area.
        /// </remarks>
        public event EventHandler<Car> CarEntered;

        /// <summary>
        /// Adds car to the Lane .
        /// </summary>
        /// <param name="car">The type of car to be processed.</param>
        public void AddCar(Car car)
        {
            if (Car.Count >= Capacity)
            {
                Console.WriteLine($"Lane is full, vehicle {car.ID} cannot enter");
                return;
            }

            Car.Add(car);
            OnCarEntered(car);
        }

        /// <summary>
        /// Raises the CarEntered event.
        /// </summary>
        /// <param name="car">The car that entered the area.</param>
        /// <remarks>
        /// This method is called to raise the CarEntered event. It invokes the event, passing the current instance of the class
        /// as the sender and the car that entered the area as the event argument.
        /// </remarks>

        protected virtual void OnCarEntered(Car car)
        {
            CarEntered?.Invoke(this, car);
        }
    }
}
