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
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _context;

        public StatusController(IStatusService context)
        {
            _context = context;
        }

        // GET: api/Status
        [HttpGet("GetAllStatus")]
        public async Task<ActionResult<IEnumerable<Status>>> GetStatus()
        {
            try
            {
                List<StatusResponse> statuslist = await _context.GetAllStatuss();
                if (statuslist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (statuslist.Count == 0)
                {
                    return NoContent();
                }
                return Ok(statuslist);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Status/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Status>> GetStatus(int id)
        {
            try
            {
                return Ok(await _context.GetStatus(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Status/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutStatus(int id, Status status)
        //{
        //    if (id != status.statusId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(status).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!StatusExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Status
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateStatus")]
        public async Task<ActionResult<Status>> PostStatus(Status status)
        {
            try
            {
                return Ok(await _context.CreateStatus(status));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Status/5
        [HttpDelete("DeleteStatus/{id}")]
        public async Task<IActionResult> DeleteStatus(int id)
        {
            try
            {
                bool result = await _context.DeleteStatus(id);
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

        //private bool StatusExists(int id)
        //{
        //    return _context.Status.Any(e => e.statusId == id);
        //}
    }
}
