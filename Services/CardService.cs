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
            this._cardRepository = cardRepository ?? throw new System.ArgumentNullException(nameof(cardRepository));
        }

        public async Task<IEnumerable<Card>> ListAsync() => await _cardRepository.ListAsync();

        public async Task<Card> GetByIdAsync(int id)
        {
            return await _cardRepository.GetByIdAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            await _cardRepository.DeleteAsync(id);
        }

        public async Task<Card> InsertAsync(Card card)
        {
            await _cardRepository.InsertAsync(card);
            return card;
        }

        public Card Update(Card card)
        {
            _cardRepository.Update(card);
            return card;
        }

    }
}