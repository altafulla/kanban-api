
using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.API.Domain.Models;
using Kanban.API.Domain.Repositories;
using Kanban.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Kanban.API.Persistence.Repositories
{
    public class CardRepository : BaseRepository, ICardRepository
    {
        public CardRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Card>> ListAsync()
        {
            return await _context.Cards.ToListAsync();
        }


    }
}
