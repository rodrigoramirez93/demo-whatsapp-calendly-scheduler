namespace Demo.Business.Models
{
    public class AppointmentBooking
    {
        public List<int> FlowSequence { get; set; } = new List<int>();
        public List<DecisionPoint> DecisionPoints { get; set; } = new List<DecisionPoint>();
    }
}