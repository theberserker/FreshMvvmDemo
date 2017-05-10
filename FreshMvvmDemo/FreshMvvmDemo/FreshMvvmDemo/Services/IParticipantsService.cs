using FreshMvvmDemo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreshMvvmDemo.Services
{
    public interface IParticipantsService
    {
        Task<IEnumerable<Participant>> GetAll();
    }
}
