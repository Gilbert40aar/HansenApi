using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Models
{
    public class Profile
    {
        [Key]
        public int profileId { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string lastName { get; set; }
        public int locationId { get; set; }
        public Location Location { get; set; }
        public int statusId { get; set; }
        public Status Status { get; set; }
        public string descripTion { get; set; }
        public int contactId { get; set; }
        public Contact Contact { get; set; }
        public string birthDay { get; set; }

    }
}
