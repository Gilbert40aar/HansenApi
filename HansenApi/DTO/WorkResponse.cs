using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.DTO
{
    public class WorkResponse
    {
        public int workId { get; set; }
        public string workTitle { get; set; }
        public string company { get; set; }
        public string addRess { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int skillsId { get; set; }
        public string descripTion { get; set; }
    }
}
