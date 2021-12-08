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
using Microsoft.AspNetCore.SignalR;

namespace HansenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly IHubContext<BroadcastHub, IHubClient> _hubContext;

        public NotificationsController(DatabaseContext context, IHubContext<BroadcastHub, IHubClient> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        [Route("notificationcount")]
        [HttpGet]
        public async Task<ActionResult<NotificationCountResult>> GetNotificationCount()
        {
            var count = (from not in _context.Notification select not).CountAsync();
            NotificationCountResult result = new NotificationCountResult
            {
                Count = await count
            };
            return result;
        }
        //// GET: api/Notifications
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Notification>>> GetNotification()
        //{
        //    return await _context.Notification.ToListAsync();
        //}

        //// GET: api/Notifications/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Notification>> GetNotification(int id)
        //{
        //    var notification = await _context.Notification.FindAsync(id);

        //    if (notification == null)
        //    {
        //        return NotFound();
        //    }

        //    return notification;
        //}

        //// PUT: api/Notifications/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutNotification(int id, Notification notification)
        //{
        //    if (id != notification.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(notification).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!NotificationExists(id))
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

        //// POST: api/Notifications
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Notification>> PostNotification(Notification notification)
        //{
        //    _context.Notification.Add(notification);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetNotification", new { id = notification.Id }, notification);
        //}

        //// DELETE: api/Notifications/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteNotification(int id)
        //{
        //    var notification = await _context.Notification.FindAsync(id);
        //    if (notification == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Notification.Remove(notification);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool NotificationExists(int id)
        //{
        //    return _context.Notification.Any(e => e.Id == id);
        //}
    }
}
