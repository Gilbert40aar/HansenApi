using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class EducationService : IEducationService
    {
        private readonly IEducationReporsitory _context;
        public EducationService(IEducationReporsitory context)
        {
            _context = context;
        }

        public async Task<Education> CreateEducation(Education _Education)
        {
            return await _context.CreateEducation(_Education);
        }

        public async Task<bool> DeleteEducation(int EducationId)
        {
            var temp = await _context.DeleteEducation(EducationId);
            return temp != null;
        }

        public async Task<List<EducationResponse>> GetAllEducations()
        {
            List<Education> education = await _context.GetAllEducations();
            return education.Select(obj => new EducationResponse
            {
                educationId = obj.educationId,
                educationTitle = obj.educationTitle,
                school = obj.school,
                startDate = obj.startDate,
                endDate = obj.endDate,
                descripTion = obj.descripTion,
                addRess = obj.addRess,
                zipCode = obj.zipCode,
                courses = obj.courses,
                internship = obj.internship,
                city = obj.city
            }).ToList();
        }

        public async Task<Education> GetEducation(int EducationId)
        {
            return await _context.GetEducation(EducationId);
        }

        public async Task<Education> UpdateEducation(int EducationId, Education _Education)
        {
            return await _context.UpdateEducation(EducationId, _Education);
        }
    }
}
