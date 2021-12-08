using System;
using System.ComponentModel.DataAnnotations;

namespace HansenApi.Models
{
    public class Messages
    {
        [Key]
        public int messagesId { get; set; }
        public DateTime sendDate { get; set; }
        public string fullName { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public int readOrNot { get; set; }
    }
}
