using System.Collections.Generic;

namespace Kanban.API.Domain.Models
{
    public class Card : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int CardlistId { get; set; }
        public Cardlist Cardlist { get; set; }
    }
}