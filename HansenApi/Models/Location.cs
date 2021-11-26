using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Models
{
    public class Location
    {
        [Key]
        public int locationId { get; set; }
        public string addRess { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
}
