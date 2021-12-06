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
    public class StatusReporsitory : IStatusReporsitory
    {
        private readonly DatabaseContext _context;
        public StatusReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Status> CreateStatus(Status _Status)
        {
            _context.Status.Add(_Status);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Status> DeleteStatus(int StatusId)
        {
            var status = _context.Status.Find(StatusId);
            if(status != null)
            {
                _context.Status.Remove(status);
                await _context.SaveChangesAsync();
            }
            return status;
        }

        public async Task<List<Status>> GetAllStatuss()
        {
            List<Status> status = await _context.Status.ToListAsync();
            return status;
        }

        public async Task<Status> GetStatus(int StatusId)
        {
            return await _context.Status.FindAsync(StatusId);
        }

        public async Task<Status> UpdateStatus(int StatusId, Status _Status)
        {
            _context.Entry(_Status).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return null;
        }
    }
}
