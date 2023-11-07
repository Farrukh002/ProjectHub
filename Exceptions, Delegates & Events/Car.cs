namespace ExceptionsDelegatesEvents
{
    /// <summary>
    /// Car class.
    /// </summary>
    internal class Car
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="id">Used for storing id of the car.</param>
        /// <param name="direction">Used for storing direction of the car.</param>
        public Car(int id, Direction direction)
        {
            ID = id;
            Direction = direction;
        }

        /// <summary>
        /// Gets or sets the car's ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the car's Direction.
        /// </summary>
        public Direction Direction { get; set; }
    }
}
