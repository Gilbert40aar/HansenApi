using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("Location.locationId")]
        public int locationId { get; set; }
        public Location Location { get; set; }
        [ForeignKey("Status.statusId")]
        public int statusId { get; set; }
        public Status Status { get; set; }
        public string descripTion { get; set; }
        [ForeignKey("Contact.contactId")]
        public int contactId { get; set; }
        public Contact Contact { get; set; }
        public string birthDay { get; set; }

    }
}
