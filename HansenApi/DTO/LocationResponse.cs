using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.DTO
{
    public class LocationResponse
    {
        public int locationId { get; set; }
        public string addRess { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
}
