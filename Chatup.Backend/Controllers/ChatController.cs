using Microsoft.AspNetCore.Mvc;
using Chatup.Backend.Models;
using Chatup.Backend.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chatup.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly MongoDbService _mongoDbService;

        public ChatController(MongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ChatMessage>>> GetMessages()
        {
            var messages = await _mongoDbService.GetMessagesAsync();
            return Ok(messages);
        }

        [HttpPost]
        public async Task<ActionResult<ChatMessage>> PostMessage(ChatMessage message)
        {
            await _mongoDbService.CreateMessageAsync(message);
            return CreatedAtAction(nameof(GetMessages), new { id = message.Id }, message);
        }
    }
}