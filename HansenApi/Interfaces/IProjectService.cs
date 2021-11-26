using HansenApi.DTO;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IProjectService
    {
        public Task<Projects> CreateProjects(Projects _Projects);
        public Task<Projects> GetProjects(int ProjectsId);
        public Task<List<ProjectResponse>> GetAllProjectss();
        public Task<Projects> UpdateProjects(int ProjectsId, Projects _Projects);
        public Task<bool> DeleteProjects(int ProjectsId);
    }
}
