using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectReporsitory _context;
        public ProjectService(IProjectReporsitory context)
        {
            _context = context;
        }

        public async Task<Projects> CreateProjects(Projects _Projects)
        {
            return await _context.CreateProjects(_Projects);
        }

        public async Task<bool> DeleteProjects(int ProjectsId)
        {
            var temp = await _context.DeleteProjects(ProjectsId);
            return temp != null;
        }

        public async Task<List<ProjectResponse>> GetAllProjectss()
        {
            List<Projects> project = await _context.GetAllProjectss();
            return project.Select(obj => new ProjectResponse
            {
                projectId = obj.projectId,
                projectTitle = obj.projectTitle,
                projectYear = obj.projectYear,
                descripTion = obj.descripTion,
                developer = obj.developer,
                genreId = obj.genreId
            }).ToList();
        }

        public async Task<Projects> GetProjects(int ProjectsId)
        {
            return await _context.GetProjects(ProjectsId);
        }

        public Task<Projects> UpdateProjects(int ProjectsId, Projects _Projects)
        {
            throw new NotImplementedException();
        }
    }
}
