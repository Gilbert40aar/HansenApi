using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Models
{
    public class Status
    {
        [Key]
        public int statusId { get; set; }
        public string work { get; set; }
        public string employee { get; set; }
    }
}
