namespace PowerliftingMeet.BusinessEntities.Attempts
{
    public class Attempt
    {
        public int AttemptId { get; set; }
        public int FlightId { get; set; }
        public int LifterId { get; set; }
        public int AttemptNumber { get; set; }
        public int? AmountInLbs { get; set; }
        public bool IsGoodLift { get; set; }
        public bool IsComplete { get; set; }
    }
}
