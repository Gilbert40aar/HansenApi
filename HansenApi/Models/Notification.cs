using System.ComponentModel.DataAnnotations;

namespace HansenApi.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string messageSubject { get; set; }
        public string TranType { get; set; }
    }
}
