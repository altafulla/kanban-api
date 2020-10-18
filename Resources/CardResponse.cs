using System.Collections.Generic;

namespace Kanban.API.Domain.Resources
{
    public class CardResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CardlistId { get; set; }

    }
}