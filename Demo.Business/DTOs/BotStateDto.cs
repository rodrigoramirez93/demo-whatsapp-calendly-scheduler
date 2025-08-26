namespace Demo.Business.DTOs
{
    public class BotStateDto
    {
        public int CurrentMessageId { get; set; }
        public int UserId { get; set; }
        public Dictionary<string, object> SessionData { get; set; } = new Dictionary<string, object>();
        public DateTime LastActivity { get; set; }
        public bool IsSessionActive { get; set; }
    }
}