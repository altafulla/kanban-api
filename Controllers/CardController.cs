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
        // public ActionResult<IEnumerable<Card>> Get()
        public async Task<IEnumerable<CardResponse>> Get()
        {
            var allCards = await _cardService.ListAsync();
            var allCardsResponse = _mapper.Map<IEnumerable<Card>, IEnumerable<CardResponse>>(allCards);
            return allCardsResponse;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<CardCreate> Post([FromBody] CardCreate cardCreate)
        {
            if (!ModelState.IsValid) return BadRequest();
            return StatusCode(201);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}