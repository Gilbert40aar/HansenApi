using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class MessagesService : IMessagesService
    {
        private readonly IMessagesReporsitory _context;

        public MessagesService(IMessagesReporsitory context)
        {
            _context = context;
        }

        public async Task<Messages> CreateMessage(Messages _message)
        {
            return await _context.CreateMessage(_message);
        }

        public async Task<bool> DeleteMessage(int _messagesId)
        {
            var temp = await _context.DeleteMessage(_messagesId);
            return temp != null;
        }

        public async Task<List<MessagesResponse>> GetAllMessages()
        {
            List<Messages> messageList = await _context.GetAllMessages();
            return messageList.Select(obj => new MessagesResponse
            {
                messagesId = obj.messagesId,
                sendDate = obj.sendDate,
                fullName = obj.fullName,
                subject = obj.subject,
                message = obj.message,
                readOrNot = obj.readOrNot
            }).ToList();
        }

        public async Task<Messages> GetMessage(int _messagesId)
        {
            return await _context.GetMessage(_messagesId);
        }
    }
}
