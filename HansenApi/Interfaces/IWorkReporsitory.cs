using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IWorkReporsitory
    {
        public Task<Work> CreateWork(Work _Work);
        public Task<Work> GetWork(int WorkId);
        public Task<List<Work>> GetAllWorks();
        public Task<Work> UpdateWork(int WorkId, Work _Work);
        public Task<Work> DeleteWork(int WorkId);
    }
}
