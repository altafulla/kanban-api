using System.Collections.Generic;

namespace Kanban.API.Domain.Models
{
    public class Cardlist : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }
        public IList<Card> Cards { set; get; } = new List<Card>();

        public User user { set; get;}
    }
}