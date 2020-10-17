
using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.API.Domain.Models;

namespace Kanban.API.Domain.Services
{
    public interface ICardService
    {
        Task<IEnumerable<Card>> ListAsync();
        Task<Card> GetByIdAsync(int id);
    }
}