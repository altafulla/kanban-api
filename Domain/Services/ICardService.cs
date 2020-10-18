
using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.API.Domain.Models;

namespace Kanban.API.Domain.Services
{
    public interface ICardService
    {
        Task<IEnumerable<Card>> ListAsync();
        Task<Card> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<Card> InsertAsync(Card card);
        Card Update(Card card);
    }
}