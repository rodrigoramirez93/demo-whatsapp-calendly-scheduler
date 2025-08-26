namespace Demo.Business.Models
{
    public class MessageHandler
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string? Type { get; set; }
        public string? Category { get; set; }
    }
}