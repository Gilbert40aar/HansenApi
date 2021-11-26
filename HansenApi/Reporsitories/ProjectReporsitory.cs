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
    public class ProjectReporsitory : IProjectReporsitory
    {
        private readonly DatabaseContext _context;
        public ProjectReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Projects> CreateProjects(Projects _Projects)
        {
            _context.Projects.Add(_Projects);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Projects> DeleteProjects(int ProjectsId)
        {
            var project = _context.Projects.Find(ProjectsId);
            if(project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
            }
            return project;
        }

        public async Task<List<Projects>> GetAllProjectss()
        {
            List<Projects> project = await _context.Projects.ToListAsync();
            return project;
        }

        public async Task<Projects> GetProjects(int ProjectsId)
        {
            return await _context.Projects.FindAsync(ProjectsId);
        }

        public Task<Projects> UpdateProjects(int ProjectsId, Projects _Projects)
        {
            throw new NotImplementedException();
        }
    }
}
