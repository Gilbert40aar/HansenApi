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
    public class WorksController : ControllerBase
    {
        private readonly IWorkService _context;

        public WorksController(IWorkService context)
        {
            _context = context;
        }

        // GET: api/Works
        [HttpGet("GetAllWork")]
        public async Task<ActionResult<IEnumerable<Work>>> GetWork()
        {
            try
            {
                List<WorkResponse> worklist = await _context.GetAllWorks();
                if (worklist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (worklist.Count == 0)
                {
                    return NoContent();
                }
                return Ok(worklist);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Works/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Work>> GetWork(int id)
        {
            try
            {
                return Ok(await _context.GetWork(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Works/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWork(int id, Work work)
        {
            try
            {
                return Ok(await _context.UpdateWork(id, work));
            } catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // POST: api/Works
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateWork")]
        public async Task<ActionResult<Work>> PostWork(Work work)
        {
            try
            {
                return Ok(await _context.CreateWork(work));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Works/5
        [HttpDelete("DeleteWork/{id}")]
        public async Task<IActionResult> DeleteWork(int id)
        {
            try
            {
                bool result = await _context.DeleteWork(id);
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

        //private bool WorkExists(int id)
        //{
        //    return _context.Work.Any(e => e.workId == id);
        //}
    }
}
