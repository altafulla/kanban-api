using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.API.Domain.Models;

namespace Kanban.API.Domain.Repositories
{
    public interface ICardRepository
    {
        Task<IEnumerable<Card>> ListAsync();
    }
}