using HansenApi.Database;
using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Reporsitories
{
    public class AdminReporsitory : IAdminReporsitory
    {
        private readonly DatabaseContext _context;
        public AdminReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Admin> AdminLogin(string userName, string passWord)
        {
            return await _context.Admin.Where(obj => obj.userName == userName && obj.passWord == passWord).FirstOrDefaultAsync();
        }

        public async Task<Admin> CreateAdmin(Admin _admin)
        {
            _context.Admin.Add(_admin);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Admin> DeleteAdmin(int adminId)
        {
            var admin = _context.Admin.Find(adminId);
            if(admin != null)
            {
                _context.Admin.Remove(admin);
                await _context.SaveChangesAsync();
            }
            return admin;
        }

        public async Task<Admin> GetAdmin(int adminId)
        {
            return await _context.Admin.FindAsync(adminId);
        }

        public async Task<List<Admin>> GetAllAdmins()
        {
            List<Admin> adminlist = await _context.Admin.ToListAsync();
            return adminlist;
        }

        public Task<Admin> UpdateAdmin(int adminId, Admin _admin)
        {
            throw new NotImplementedException();
        }
    }
}
