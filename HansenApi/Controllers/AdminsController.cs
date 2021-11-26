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
    public class AdminsController : ControllerBase
    {
        private readonly IAdminService _context;

        public AdminsController(IAdminService context)
        {
            _context = context;
        }

        // GET: api/Admins
        [HttpGet("GetAllAdmin")]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdmin()
        {
            try
            {
                List<AdminResponse> adminlist = await _context.GetAllAdmins();
                if (adminlist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (adminlist.Count == 0)
                {
                    return NoContent();
                }
                return Ok(adminlist);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Admins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetAdmin(int id)
        {
            try
            {
                return Ok(await _context.GetAdmin(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        [HttpGet("AdminLogin/{username}/{password}")]
        public async Task<ActionResult<LoginResponse>> AdminLogin(string username, string password)
        {
            try
            {
                return Ok(await _context.AdminLogin(username, password));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Admins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAdmin(int id, Admin admin)
        //{
        //    if (id != admin.adminId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(admin).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AdminExists(id))
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

        // POST: api/Admins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateAdmin")]
        public async Task<ActionResult<Admin>> PostAdmin(Admin admin)
        {
            //return Ok(500);
            try
            {
                return Ok(await _context.CreateAdmin(admin));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Admins/5
        [HttpDelete("DeleteAdmin/{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            try
            {
                bool result = await _context.DeleteAdmin(id);
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

        //private bool AdminExists(int id)
        //{
        //    return _context.Admin.Any(e => e.adminId == id);
        //}
    }
}
