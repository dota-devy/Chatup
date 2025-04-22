using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chatup.Backend.Services
{
    public class MongoDbService
    {
        private readonly IMongoCollection<ChatMessage> _chatMessages;

        public MongoDbService(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("ChatupDb");
            _chatMessages = database.GetCollection<ChatMessage>("ChatMessages");
        }

        public async Task<List<ChatMessage>> GetChatMessagesAsync()
        {
            return await _chatMessages.Find(message => true).ToListAsync();
        }

        public async Task<ChatMessage> GetChatMessageAsync(string id)
        {
            return await _chatMessages.Find<ChatMessage>(message => message.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateChatMessageAsync(ChatMessage chatMessage)
        {
            await _chatMessages.InsertOneAsync(chatMessage);
        }

        public async Task UpdateChatMessageAsync(string id, ChatMessage chatMessage)
        {
            await _chatMessages.ReplaceOneAsync(message => message.Id == id, chatMessage);
        }

        public async Task DeleteChatMessageAsync(string id)
        {
            await _chatMessages.DeleteOneAsync(message => message.Id == id);
        }
    }
}