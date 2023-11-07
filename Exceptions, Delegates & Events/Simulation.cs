namespace ExceptionsDelegatesEvents
{
    /// <summary>
    /// Simulation class.
    /// </summary>
    public class Simulation
    {
        private readonly TrafficController controller;
        private readonly Lane straightLane;
        private readonly Lane rightLane;
        private readonly Lane leftLane;
        private readonly Random random;

        /// <summary>
        /// Initializes a new instance of the <see cref="Simulation"/> class.
        /// </summary>
        public Simulation()
        {
            random = new Random();
            straightLane = new Lane(5);
            rightLane = new Lane(5);
            leftLane = new Lane(5);
            controller = new TrafficController();
        }

        /// <summary>
        /// Starts the traffic simulation.
        /// </summary>
        public void Start()
        {
            straightLane.CarEntered += OnCarEntered;
            rightLane.CarEntered += OnCarEntered;
            leftLane.CarEntered += OnCarEntered;

            while (true)
            {
                var car = new Car(random.Next(1000), (Direction)random.Next(1, 4));
                var lane = GetLane(car.Direction);

                if (lane != null)
                {
                    lane.AddCar(car);
                }

                controller.UpdatePosition();

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Retrieves the appropriate lane based on the specified direction.
        /// </summary>
        /// <param name="direction">The direction for which to retrieve the lane.</param>
        /// <returns>The lane corresponding to the specified direction, or null if no lane matches the direction.</returns>
        private Lane GetLane(Direction direction)
        {
            switch (direction)
            {
                case Direction.Straight:
                    return straightLane;
                case Direction.Left:
                    return leftLane;
                case Direction.Right:
                    return rightLane;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Event handler method called when a car enters a lane.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="car">The car that entered the lane.</param>
        private void OnCarEntered(object sender, Car car)
        {
            if (!controller.CanEnterLane(car))
            {
                Console.WriteLine($"Car {car.ID} is waiting at the traffic controller to go to {car.Direction} direction");
            }
        }
    }
}
