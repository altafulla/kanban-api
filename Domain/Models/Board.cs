using System.Collections.Generic;

namespace Kanban.API.Domain.Models
{
    public class Board : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }
        public IList<Cardlist> Cardlists { get; set; }
    }
}