using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IEducationReporsitory
    {
        public Task<Education> CreateEducation(Education _Education);
        public Task<Education> GetEducation(int EducationId);
        public Task<List<Education>> GetAllEducations();
        public Task<Education> UpdateEducation(int EducationId, Education _Education);
        public Task<Education> DeleteEducation(int EducationId);
    }
}
