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
    public class ContactReporsitory : IContactReporsitory
    {
        private readonly DatabaseContext _context;
        public ContactReporsitory(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Contact> CreateContact(Contact _contact)
        {
            _context.Contact.Add(_contact);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<Contact> DeleteContact(int contactId)
        {
            var contact = _context.Contact.Find(contactId);
            if (contact != null)
            {
                _context.Contact.Remove(contact);
                await _context.SaveChangesAsync();
            }
            return contact;
        }

        public async Task<List<Contact>> GetAllContacts()
        {
            List<Contact> contact = await _context.Contact.ToListAsync();
            return contact;
        }

        public async Task<Contact> GetContact(int contactId)
        {
            return await _context.Contact.FindAsync(contactId);
        }

        public async Task<Contact> UpdateContact(int contactId, Contact _contact)
        {
            _context.Entry(_contact).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return null;
        }
    }
}
