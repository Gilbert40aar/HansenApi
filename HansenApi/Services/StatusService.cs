using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusReporsitory _context;
        public StatusService(IStatusReporsitory context)
        {
            _context = context;
        }

        public async Task<Status> CreateStatus(Status _Status)
        {
            return await _context.CreateStatus(_Status);
        }

        public async Task<bool> DeleteStatus(int StatusId)
        {
            var temp = await _context.DeleteStatus(StatusId);
            return temp != null;
        }

        public async Task<List<StatusResponse>> GetAllStatuss()
        {
            List<Status> status = await _context.GetAllStatuss();
            return status.Select(obj => new StatusResponse
            {
                statusId = obj.statusId,
                employee = obj.employee,
                work = obj.work
            }).ToList();
        }

        public async Task<Status> GetStatus(int StatusId)
        {
            return await _context.GetStatus(StatusId);
        }

        public async Task<Status> UpdateStatus(int StatusId, Status _Status)
        {
            return await _context.UpdateStatus(StatusId, _Status);
        }
    }
}
