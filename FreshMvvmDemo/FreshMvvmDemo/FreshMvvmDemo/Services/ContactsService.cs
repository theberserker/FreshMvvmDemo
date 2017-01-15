using FreshMvvmDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshMvvmDemo.Services
{
    public class ContactsService : IContactsService
    {
        public async Task<IEnumerable<Contact>> GetContacts()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return new List<Contact>
            {
                new Contact { Id=1121, Name="David Gómez" },
                new Contact { Id=1122, Name="Germán Mono Burgos" },
                new Contact { Id=1123, Name="Diego Pablo Simeone" },
            };
        }
    }
}
