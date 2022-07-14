using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetById(int id)
        {
            return new ContactDTO()
            {
                Id = id,
                FirstName = "Fuad",
                LastName = "Muradov"
            };
        }
    }
}
