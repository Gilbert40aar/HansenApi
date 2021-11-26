using HansenApi.DTO;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface ISkillService
    {
        public Task<Skills> CreateSkills(Skills _Skills);
        public Task<Skills> GetSkills(int SkillsId);
        public Task<List<SkillsResponse>> GetAllSkillss();
        public Task<Skills> UpdateSkills(int SkillsId, Skills _Skills);
        public Task<bool> DeleteSkills(int SkillsId);
    }
}
