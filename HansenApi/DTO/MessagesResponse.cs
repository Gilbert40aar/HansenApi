using System;

namespace HansenApi.DTO
{
    public class MessagesResponse
    {
        public int messagesId { get; set; }
        public DateTime sendDate { get; set; }
        public string fullName { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public int readOrNot { get; set; }
    }
}
