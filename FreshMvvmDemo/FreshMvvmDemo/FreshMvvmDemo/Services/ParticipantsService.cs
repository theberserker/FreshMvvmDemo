using FreshMvvmDemo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreshMvvmDemo.Services
{
    public class ParticipantsService : IParticipantsService
    {
        public async Task<IEnumerable<Participant>> GetContacts()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return new List<Participant>
            {
                new Participant { Id=1121, Name="David Gómez" },
                new Participant { Id=1122, Name="Germán Mono Burgos" },
                new Participant { Id=1123, Name="Diego Pablo Simeone" },
            };
        }
    }
}
