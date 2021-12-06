using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class SkillService : ISkillService
    {
        private readonly ISkillsReporsitory _context;
        public SkillService(ISkillsReporsitory context)
        {
            _context = context;
        }

        public async Task<Skills> CreateSkills(Skills _Skills)
        {
            return await _context.CreateSkills(_Skills);
        }

        public async Task<bool> DeleteSkills(int SkillsId)
        {
            var temp = await _context.DeleteSkills(SkillsId);
            return temp != null;
        }

        public async Task<List<SkillsResponse>> GetAllSkillss()
        {
            List<Skills> skill = await _context.GetAllSkillss();
            return skill.Select(obj => new SkillsResponse
            {
                skillsId = obj.skillsId,
                skillsTitle = obj.skillsTitle,
                skillsIcon = obj.skillsIcon,
                skillsPoints = obj.skillsPoints
            }).ToList();
        }

        public async Task<Skills> GetSkills(int SkillsId)
        {
            return await _context.GetSkills(SkillsId);
        }

        public async Task<Skills> UpdateSkills(int SkillsId, Skills _Skills)
        {
            return await _context.UpdateSkills(SkillsId, _Skills);
        }
    }
}
