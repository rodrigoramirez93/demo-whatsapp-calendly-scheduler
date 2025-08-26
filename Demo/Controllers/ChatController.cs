using Demo.Business;
using Demo.Business.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly Engine _engine;

        public ChatController(Engine engine)
        {
            _engine = engine;
        }

        [HttpPost(Name = "Chat")]
        public async Task RespondAsync(Request request)
        {
            var result = await _engine
                .Start(request)
                .Process();

            //_engine.Respond(result);
        }
    }
}
