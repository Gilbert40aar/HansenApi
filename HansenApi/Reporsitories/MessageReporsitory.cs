using HansenApi.Database;
using HansenApi.Interfaces;
using HansenApi.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Reporsitories
{
    public class MessageReporsitory : IMessagesReporsitory
    {
        private readonly DatabaseContext _context;
        private readonly IHubContext<BroadcastHub, IHubClient> _hubContext;

        public MessageReporsitory(DatabaseContext context, IHubContext<BroadcastHub, IHubClient> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        public async Task<Messages> CreateMessage(Messages _message)
        {
            _context.Messages.Add(_message);

            Notification notification = new Notification()
            {
                messageSubject = _message.subject,
                TranType = "Add"
            };
            _context.Notification.Add(notification);
            try
            {
                await _context.SaveChangesAsync();
                await _hubContext.Clients.All.BroadcastMessage();
            } catch (DbUpdateException)
            {
                if (MessageExists(_message.messagesId))
                {
                    return Conflict();
                } else
                {
                    throw;
                }
            }

            
            return null;
        }

        private Messages Conflict()
        {
            throw new NotImplementedException();
        }

        public async Task<Messages> DeleteMessage(int _messagesId)
        {
            var message = _context.Messages.Find(_messagesId);
            if (message != null)
            {
                _context.Messages.Remove(message);
                await _context.SaveChangesAsync();
            }
            return message;
        }

        public async Task<List<Messages>> GetAllMessages()
        {
            List<Messages> messageList = await _context.Messages.ToListAsync();
            return messageList;
        }

        public async Task<Messages> GetMessage(int _messagesId)
        {
            return await _context.Messages.FindAsync(_messagesId);
        }

        private bool MessageExists(int messagesId)
        {
            return _context.Messages.Any(e => e.messagesId == messagesId);
        }
    }
}
