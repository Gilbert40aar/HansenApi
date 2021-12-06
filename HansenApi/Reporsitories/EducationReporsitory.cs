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
    public class EducationReporsitory : IEducationReporsitory
    {
        private readonly DatabaseContext _context;
        public EducationReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Education> CreateEducation(Education _Education)
        {
            _context.Education.Add(_Education);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Education> DeleteEducation(int EducationId)
        {
            var education = _context.Education.Find(EducationId);
            if(education != null)
            {
                _context.Education.Remove(education);
                await _context.SaveChangesAsync();
            }
            return education;
        }

        public async Task<List<Education>> GetAllEducations()
        {
            List<Education> education = await _context.Education.ToListAsync();
            return education;
        }

        public async Task<Education> GetEducation(int EducationId)
        {
            return await _context.Education.FindAsync(EducationId);
        }

        public async Task<Education> UpdateEducation(int EducationId, Education _Education)
        {
            _context.Entry(_Education).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return null;
        }
    }
}
