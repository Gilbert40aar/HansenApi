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
    public class WorkReporsitory : IWorkReporsitory
    {
        private readonly DatabaseContext _context;
        public WorkReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Work> CreateWork(Work _Work)
        {
            _context.Work.Add(_Work);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Work> DeleteWork(int WorkId)
        {
            var work = _context.Work.Find(WorkId);
            if(work != null)
            {
                _context.Work.Remove(work);
                await _context.SaveChangesAsync();
            }
            return work;
        }

        public async Task<List<Work>> GetAllWorks()
        {
            List<Work> work = await _context.Work.ToListAsync();
            return work;
        }

        public async Task<Work> GetWork(int WorkId)
        {
            return await _context.Work.FindAsync(WorkId);
        }

        public async Task<Work> UpdateWork(int WorkId, Work _Work)
        {
            _context.Entry(_Work).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return null;
        }
    }
}
