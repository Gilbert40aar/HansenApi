using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HansenApi.Database;
using HansenApi.Models;
using HansenApi.Interfaces;
using HansenApi.DTO;

namespace HansenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _context;

        public ProjectsController(IProjectService context)
        {
            _context = context;
        }

        // GET: api/Projects
        [HttpGet("GetAllProjects")]
        public async Task<ActionResult<IEnumerable<Projects>>> GetProjects()
        {
            try
            {
                List<ProjectResponse> projectlist = await _context.GetAllProjectss();
                if (projectlist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (projectlist.Count == 0)
                {
                    return NoContent();
                }
                return Ok(projectlist);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Projects>> GetProjects(int id)
        {
            try
            {
                return Ok(await _context.GetProjects(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Projects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjects(int id, Projects projects)
        {
            try
            {
                return Ok(await _context.UpdateProjects(id, projects));
            } catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        // POST: api/Projects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateProject")]
        public async Task<ActionResult<Projects>> PostProjects(Projects projects)
        {
            try
            {
                return Ok(await _context.CreateProjects(projects));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Projects/5
        [HttpDelete("DeleteProject/{id}")]
        public async Task<IActionResult> DeleteProjects(int id)
        {
            try
            {
                bool result = await _context.DeleteProjects(id);
                if (!result)
                {
                    return Problem("Something went wrong, trying to delete the movie");
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        //private bool ProjectsExists(int id)
        //{
        //    return _context.Projects.Any(e => e.projectId == id);
        //}
    }
}
