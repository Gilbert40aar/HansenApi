using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IProjectReporsitory
    {
        public Task<Projects> CreateProjects(Projects _Projects);
        public Task<Projects> GetProjects(int ProjectsId);
        public Task<List<Projects>> GetAllProjectss();
        public Task<Projects> UpdateProjects(int ProjectsId, Projects _Projects);
        public Task<Projects> DeleteProjects(int ProjectsId);
    }
}
