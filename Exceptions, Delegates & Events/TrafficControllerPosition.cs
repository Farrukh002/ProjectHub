namespace ExceptionsDelegatesEvents
{
    /// <summary>
    /// TrafficControllerPosition is an enum used for storing the position of traffic controller.
    /// </summary>
    public enum TrafficControllerPosition
    {
        /// <summary>
        /// Used for storing SidewaysAndArmsLoweredOrExtended position of traffic controller and it means move straight or to the right.
        /// </summary>
        SidewaysAndArmsLoweredOrExtended = 1,

        /// <summary>
        /// Used for storing FacingAndArmsExtended position of traffic controller and it means a right turn is allowed.
        /// </summary>
        FacingAndArmsExtended = 2,

        /// <summary>
        /// Used for storing LeftSideAndRightArmsExtendedForward position of traffic controller and it means any direction is allowed.
        /// </summary>
        LeftSideAndRightArmsExtendedForward = 3,

        /// <summary>
        /// Used for storing OtherPositions position of traffic controller and it means any movement is prohibited.
        /// </summary>
        OtherPositions = 4,
    }
}
