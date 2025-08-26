namespace Demo.Data.Domain
{
    public class Conversation
    {
        public string Id { get; set; }
        public int? MessageId { get; set; }
        public string? CreatedAt { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
    }
}
