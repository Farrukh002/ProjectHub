namespace ExceptionsDelegatesEvents
{
    /// <summary>
    /// TrafficController class.
    /// </summary>
    internal class TrafficController
    {
        private TrafficControllerPosition position;

        /// <summary>
        /// Updates the position of Traffic controller.
        /// </summary>
        public void UpdatePosition()
        {
            int rnd = new Random().Next(4);
            position = (TrafficControllerPosition)rnd;
        }

        /// <summary>
        /// Checks if a car can enter the lane based on the current traffic controller position.
        /// </summary>
        /// <param name="car">The car to check.</param>
        /// <returns><c>true</c> if the car can enter the lane; otherwise, <c>false</c>.</returns>
        public bool CanEnterLane(Car car)
        {
            switch (position)
            {
                case TrafficControllerPosition.SidewaysAndArmsLoweredOrExtended:
                    return car.Direction == Direction.Straight || car.Direction == Direction.Right;
                case TrafficControllerPosition.FacingAndArmsExtended:
                    return car.Direction == Direction.Right;
                case TrafficControllerPosition.LeftSideAndRightArmsExtendedForward:
                    return true;
                default:
                    return false;
            }
        }
    }
}
