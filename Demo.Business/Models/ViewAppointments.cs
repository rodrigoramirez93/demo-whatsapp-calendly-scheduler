namespace Demo.Business.Models
{
    public class ViewAppointments
    {
        public List<int> FlowSequence { get; set; } = new List<int>();
        public List<ConditionalMessage> ConditionalMessages { get; set; } = new List<ConditionalMessage>();
    }
}