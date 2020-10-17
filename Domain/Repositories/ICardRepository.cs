using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.API.Domain.Models;
using Kanban.API.Persistence.Repositories;

namespace Kanban.API.Domain.Repositories
{
    public interface ICardRepository : IRepository<Card>
    {
        Task<IEnumerable<Card>> ListAsync();
    }
}