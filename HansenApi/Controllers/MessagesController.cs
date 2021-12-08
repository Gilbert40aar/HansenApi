using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HansenApi.Database;
using HansenApi.Models;
using HansenApi.Services;
using HansenApi.DTO;
using Microsoft.AspNetCore.SignalR;
using HansenApi.Interfaces;

namespace HansenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessagesService _context;
        //private readonly IHubContext<BroadcastHub, IHubClient> _hubContaxt;

        public MessagesController(IMessagesService context)
        {
            _context = context;
        }

        // GET: api/Messages
        [HttpGet("GetAllMessages")]
        public async Task<ActionResult<IEnumerable<Messages>>> GetMessages()
        {
            try
            {
                List<MessagesResponse> messageList = await _context.GetAllMessages();
                if(messageList == null)
                {
                    return Problem("There is no messages to recieve");
                }
                if(messageList.Count == 0)
                {
                    return NoContent();
                }
                return Ok(messageList);
            } catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        // GET: api/Messages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Messages>> GetMessages(int id)
        {
            try
            {
                return Ok(await _context.GetMessage(id));
            } catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        // PUT: api/Messages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMessages(int id, Messages messages)
        //{
        //    if (id != messages.messagesId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(messages).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MessagesExists(id))
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

        // POST: api/Messages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateMessage")]
        public async Task<ActionResult<Messages>> PostMessages(Messages messages)
        {
            try
            {
                return Ok(await _context.CreateMessage(messages));
            } catch(Exception e)
            {
                return Problem(e.Message);
            }
        }

        // DELETE: api/Messages/5
        [HttpDelete("DeleteMessage/{id}")]
        public async Task<IActionResult> DeleteMessages(int id)
        {
            try
            {
                bool result = await _context.DeleteMessage(id);
                if(!result)
                {
                    return Problem("Something went wrong, Trying to delete the message");
                }
                return Ok(result);
            } catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        //private bool MessagesExists(int id)
        //{
        //    return _context.Messages.Any(e => e.messagesId == id);
        //}
    }
}
