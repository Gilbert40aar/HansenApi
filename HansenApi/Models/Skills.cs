using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Models
{
    public class Skills
    {
        [Key]
        public int skillsId { get; set; }
        public string skillsTitle { get; set; }
        public string skillsIcon { get; set; }
        public string skillsPoints { get; set; }
    }
}
