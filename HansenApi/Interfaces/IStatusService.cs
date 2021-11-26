using HansenApi.DTO;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IStatusService
    {
        public Task<Status> CreateStatus(Status _Status);
        public Task<Status> GetStatus(int StatusId);
        public Task<List<StatusResponse>> GetAllStatuss();
        public Task<Status> UpdateStatus(int StatusId, Status _Status);
        public Task<bool> DeleteStatus(int StatusId);
    }
}
