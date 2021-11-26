using HansenApi.Database;
using HansenApi.Interfaces;
using HansenApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Reporsitories
{
    public class SkillsReporsitory : ISkillsReporsitory
    {
        private readonly DatabaseContext _context;
        public SkillsReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Skills> CreateSkills(Skills _Skills)
        {
            _context.Skills.Add(_Skills);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Skills> DeleteSkills(int SkillsId)
        {
            var skill = _context.Skills.Find(SkillsId);
            if(skill != null)
            {
                _context.Skills.Remove(skill);
                await _context.SaveChangesAsync();
            }
            return skill;
        }

        public async Task<List<Skills>> GetAllSkillss()
        {
            List<Skills> skill = await _context.Skills.ToListAsync();
            return skill;
        }

        public async Task<Skills> GetSkills(int SkillsId)
        {
            return await _context.Skills.FindAsync(SkillsId);
        }

        public Task<Skills> UpdateSkills(int SkillsId, Skills _Skills)
        {
            throw new NotImplementedException();
        }
    }
}
