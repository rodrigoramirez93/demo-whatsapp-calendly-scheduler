using Demo.Business.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Demo.Business.Helpers
{
    public static class Helper
    {
        public static BotMessage? FindMessageById(this DemoBotConfiguration config, int messageId)
        {
            return config.Messages.Find(m => m.Id == messageId);
        }

        public static List<BotMessage> GetMessagesForFeature(this DemoBotConfiguration config, int featureId)
        {
            return config.Messages.FindAll(m => m.BotFeatures.Contains(featureId));
        }

        public static MessageHandler? FindHandlerById(this DemoBotConfiguration config, int handlerId)
        {
            return config.MessageHandlers.Find(h => h.Id == handlerId);
        }

        public static BotFeature? FindFeatureById(this DemoBotConfiguration config, int featureId)
        {
            return config.BotFeatures.Find(f => f.Id == featureId);
        }

        public static List<BotMessage> GetErrorMessages(this DemoBotConfiguration config)
        {
            return config.Messages.FindAll(m => m.IsErrorMessage());
        }

        public static BotMessage? GetNextMessage(this DemoBotConfiguration config, int currentMessageId)
        {
            var currentMessage = config.FindMessageById(currentMessageId);
            if (currentMessage?.SuccessorId.HasValue == true)
            {
                return config.FindMessageById(currentMessage.SuccessorId.Value);
            }
            return null;
        }

        public static BotMessage? GetPreviousMessage(this DemoBotConfiguration config, int currentMessageId)
        {
            var currentMessage = config.FindMessageById(currentMessageId);
            if (currentMessage?.PredecessorId.HasValue == true)
            {
                return config.FindMessageById(currentMessage.PredecessorId.Value);
            }
            return null;
        }

        public static DemoBotConfiguration? LoadConfig()
        {
            string configPath = Path.Combine(AppContext.BaseDirectory, "config.json");
            var json = File.ReadAllText(configPath);
            return JsonConvert.DeserializeObject<DemoBotConfiguration>(json, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                }
            });
        }
    }
}