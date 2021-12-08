using HansenApi.DTO;
using HansenApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IMessagesService
    {
        public Task<Messages> CreateMessage(Messages _message);

        public Task<Messages> GetMessage(int _messagesId);

        public Task<List<MessagesResponse>> GetAllMessages();

        public Task<bool> DeleteMessage(int _messagesId);
    }
}
