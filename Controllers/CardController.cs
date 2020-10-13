using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.API.Domain.Models;
using Kanban.API.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kanban.API.Controllers
{
    [Route("/api/[controller]")]
    public class CardController : Controller
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }


        [HttpGet]
        // public ActionResult<IEnumerable<Card>> Get()
        public async Task<IEnumerable<Card>> Get()
        {
            var allCards = await _cardService.ListAsync();
            return allCards;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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