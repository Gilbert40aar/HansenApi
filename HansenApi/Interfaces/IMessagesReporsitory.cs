using HansenApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IMessagesReporsitory
    {
        public Task<Messages> CreateMessage(Messages _message);

        public Task<Messages> GetMessage(int _messagesId);

        public Task<List<Messages>> GetAllMessages();

        public Task<Messages> DeleteMessage(int _messagesId);
    }
}
