namespace Demo.Business.DTOs
{
    public class BotMessageDto
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string HandlerName { get; set; } = string.Empty;
        public int? NextMessageId { get; set; }
        public List<string> AvailableActions { get; set; } = new List<string>();
    }
}