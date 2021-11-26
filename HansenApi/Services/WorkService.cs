using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class WorkService : IWorkService
    {
        private readonly IWorkReporsitory _context;
        public WorkService(IWorkReporsitory context)
        {
            _context = context;
        }

        public async Task<Work> CreateWork(Work _Work)
        {
            return await _context.CreateWork(_Work);
        }

        public async Task<bool> DeleteWork(int WorkId)
        {
            var temp = await _context.DeleteWork(WorkId);
            return temp != null;
        }

        public async Task<List<WorkResponse>> GetAllWorks()
        {
            List<Work> work = await _context.GetAllWorks();
            return work.Select(obj => new WorkResponse
            {
                workId = obj.workId,
                workTitle = obj.workTitle,
                company = obj.company,
                addRess = obj.addRess,
                zipCode = obj.zipCode,
                city = obj.city,
                startDate = obj.startDate,
                endDate = obj.endDate,
                descripTion = obj.descripTion,
                skillsId = obj.skillsId
            }).ToList();
        }

        public async Task<Work> GetWork(int WorkId)
        {
            return await _context.GetWork(WorkId);
        }

        public Task<Work> UpdateWork(int WorkId, Work _Work)
        {
            throw new NotImplementedException();
        }
    }
}
