using HansenApi.DTO;
using HansenApi.Interfaces;
using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Services
{
    public class ContactService :IContactService
    {
        private readonly IContactReporsitory _context;
        public ContactService(IContactReporsitory context)
        {
            _context = context;
        }

        public async Task<Contact> CreateContact(Contact _contact)
        {
            return await _context.CreateContact(_contact);
        }

        public async Task<bool> DeleteContact(int contactId)
        {
            var temp = await _context.DeleteContact(contactId);
            return temp != null;
        }

        public async Task<List<ContactResponse>> GetAllContacts()
        {
            List<Contact> contactlist = await _context.GetAllContacts();
            return contactlist.Select(obj => new ContactResponse
            {
                contactId = obj.contactId,
                email = obj.email,
                phone = obj.phone
            }).ToList();
        }

        public async Task<Contact> GetContact(int contactId)
        {
            return await _context.GetContact(contactId);
        }

        public async Task<Contact> UpdateContact(int contactId, Contact _contact)
        {
            return await _context.UpdateContact(contactId, _contact);
        }
    }
}
