using Demo.Business.DTOs;
using Demo.Business.Helpers;
using Demo.Business.Models;
using Demo.Data;
using Demo.Data.Domain;

namespace Demo.Business;

public class Engine
{
    private readonly DemoBotConfiguration? _configuration;
    private readonly IConversationRepository _conversationRepository;
    private Request? _request;
    private Conversation? _conversation;

    public Engine(IConversationRepository conversationRepository)
    {
        _configuration = Helper.LoadConfig();
        _conversationRepository = conversationRepository;
    }

    public Engine Start(Request request)
    {
        _request = request;
        return this;
    }

    public async Task<Engine> Process()
    {
        _conversation = await EngineConversationHelper.EnsureConversationExistsAsync(_conversationRepository, _request!.From, _request!.To, Guid.NewGuid());

        return this;
    }

    public void Respond()
    {

    }
}