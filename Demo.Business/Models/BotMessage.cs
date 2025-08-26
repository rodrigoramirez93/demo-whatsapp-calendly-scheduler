namespace Demo.Business.Models
{
    public class BotMessage
    {
        public int Id { get; set; }
        public int HandlerId { get; set; }
        public int? SuccessorId { get; set; }
        public int? PredecessorId { get; set; }
        public int TagId { get; set; }
        public string Text { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public List<int> BotFeatures { get; set; } = new List<int>();
    }
}