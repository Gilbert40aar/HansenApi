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
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _context;

        public ContactsController(IContactService context)
        {
            _context = context;
        }

        // GET: api/Contacts
        [HttpGet("GetAllContacts")]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContact()
        {
            try
            {
                List<ContactResponse> contactlist = await _context.GetAllContacts();
                if (contactlist == null)
                {
                    return Problem("There is no movies in the database yet");
                }
                if (contactlist.Count == 0)
                {
                    return NoContent();
                }
                return Ok(contactlist);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Contacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact(int id)
        {
            try
            {
                return Ok(await _context.GetContact(id));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            };
        }

        // PUT: api/Contacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("UpdateContacts/{id}")]
        public async Task<IActionResult> PutContact(int id, Contact contact)
        {
            try
            {
                return Ok(await _context.UpdateContact(id, contact));
            } catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // POST: api/Contacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateContact")]
        public async Task<ActionResult<Contact>> PostContact(Contact contact)
        {
            try
            {
                return Ok(await _context.CreateContact(contact));
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Contacts/5
        [HttpDelete("DeleteContact/{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            try
            {
                bool result = await _context.DeleteContact(id);
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

        //private bool ContactExists(int id)
        //{
        //    return _context.Contact.Any(e => e.contactId == id);
        //}
    }
}
