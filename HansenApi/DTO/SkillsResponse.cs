using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.DTO
{
    public class SkillsResponse
    {
        public int skillsId { get; set; }
        public string skillsTitle { get; set; }
        public string skillsIcon { get; set; }
        public string skillsPoints { get; set; }
    }
}
