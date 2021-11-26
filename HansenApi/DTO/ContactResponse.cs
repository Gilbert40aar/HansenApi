using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.DTO
{
    public class ContactResponse
    {
        public int contactId { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }
}
