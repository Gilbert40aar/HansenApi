using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.DTO
{
    public class EducationResponse
    {
        public int educationId { get; set; }
        public string educationTitle { get; set; }
        public string school { get; set; }
        public string addRess { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string courses { get; set; }
        public string internship { get; set; }
        public string descripTion { get; set; }
    }
}
