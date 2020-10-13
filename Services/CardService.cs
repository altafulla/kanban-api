using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.API.Domain.Models;
using Kanban.API.Domain.Services;
using Kanban.API.Domain.Repositories;

namespace Kanban.API.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;
        public CardService(
            ICardRepository cardRepository
        )
        {
            this._cardRepository = cardRepository;
        }
        async Task<IEnumerable<Card>> ICardService.ListAsync()
        {
            return await _cardRepository.ListAsync();
        }
    }
}