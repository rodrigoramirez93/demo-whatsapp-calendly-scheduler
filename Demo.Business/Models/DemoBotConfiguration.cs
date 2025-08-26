namespace Demo.Business.Models
{
    public class DemoBotConfiguration
    {
        public int ProviderId { get; set; }
        public string BotName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SessionTimeoutMinutes { get; set; }
        public int LanguageId { get; set; }
        public string Language { get; set; } = string.Empty;

        public List<MessageTag> MessageTags { get; set; } = new List<MessageTag>();
        public List<MessageHandler> MessageHandlers { get; set; } = new List<MessageHandler>();
        public List<BotFeature> BotFeatures { get; set; } = new List<BotFeature>();
        public List<BotMessage> Messages { get; set; } = new List<BotMessage>();
        public ConversationFlows ConversationFlows { get; set; } = new ConversationFlows();
    }
}