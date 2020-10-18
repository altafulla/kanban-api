using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Kanban.API.Domain.Models;
using Kanban.API.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kanban.API.Controllers
{
    [Route("/api/[controller]")]
    public class CardController : Controller
    {
        private readonly ICardService _cardService;
        private readonly IMapper _mapper;
        public CardController(ICardService cardService, IMapper mapper)
        {
            _cardService = cardService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IEnumerable<CardResponse>> GetAllAsync()
        {
            var allCards = await _cardService.ListAsync();
            var allCardsResponse = _mapper.Map<IEnumerable<Card>, IEnumerable<CardResponse>>(allCards);
            return allCardsResponse;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CardResponse>> GetByIdAsync(int id)
        {
            var card = await _cardService.GetByIdAsync(id);
            var cardResponse = _mapper.Map<Card, CardResponse>(card);
            return cardResponse;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<CardCreate>> PostAsync([FromBody] CardCreate cardCreate)
        {
            var card = _mapper.Map<CardCreate, Card>(cardCreate);
            await _cardService.InsertAsync(card);
            return StatusCode(201);
        }

        // PUT api/values
        [HttpPut]
        public ActionResult<CardCreate> Put([FromBody] CardCreate cardCreate)
        {
            var card = _mapper.Map<CardCreate, Card>(cardCreate);
            _cardService.Update(card);
            return StatusCode(201);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _cardService.DeleteAsync(id);
        }
    }
}