using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Models
{
    public class Contact
    {
        [Key]
        public int contactId { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }
}
