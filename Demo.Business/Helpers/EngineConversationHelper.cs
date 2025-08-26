using Demo.Data;
using Demo.Data.Domain;

namespace Demo.Business.Helpers
{
    internal static class EngineConversationHelper
    {
        internal static async Task<Conversation> EnsureConversationExistsAsync(IConversationRepository repo, string from, string to, Guid conversationId)
        {
            var conversations = await repo.GetAllConversationsAsync();

            if (conversations.Any(conversation => conversation.From == from))
            {
                var existingConversation = conversations
                    .OrderByDescending(conversation => DateTimeOffset.Parse(conversation?.CreatedAt!))
                    .First(conversation => conversation.From == from);

                return existingConversation;
            }

            await repo.CreateConversationAsync(conversationId, from, to);

            conversations = await repo.GetAllConversationsAsync();

            var newConversation = conversations.Single(conversation => Guid.Parse(conversation.Id) == conversationId);

            return newConversation;
        }
    }
}
