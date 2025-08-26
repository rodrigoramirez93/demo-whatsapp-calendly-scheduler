using Demo.Business.Models;

namespace Demo.Business
{
    public static class Extension
    {
        public static bool IsErrorMessage(this BotMessage message)
        {
            return message.Id < 0;
        }

        public static bool HasSuccessor(this BotMessage message)
        {
            return message.SuccessorId.HasValue;
        }

        public static bool HasPredecessor(this BotMessage message)
        {
            return message.PredecessorId.HasValue;
        }

        public static bool IsButtonMessage(this BotMessage message)
        {
            return message.Type.Equals("button", StringComparison.OrdinalIgnoreCase);
        }

        public static bool RequiresUserInput(this BotMessage message)
        {
            return message.Type.Equals("input_request", StringComparison.OrdinalIgnoreCase) ||
                   message.Type.Equals("selection", StringComparison.OrdinalIgnoreCase);
        }
    }
}