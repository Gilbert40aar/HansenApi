using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface ISkillsReporsitory
    {
        public Task<Skills> CreateSkills(Skills _Skills);
        public Task<Skills> GetSkills(int SkillsId);
        public Task<List<Skills>> GetAllSkillss();
        public Task<Skills> UpdateSkills(int SkillsId, Skills _Skills);
        public Task<Skills> DeleteSkills(int SkillsId);
    }
}
