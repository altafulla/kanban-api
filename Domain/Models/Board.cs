using System.Collections.Generic;

namespace Kanban.API.Domain.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }
        public IList<Cardlist> Cardlists { get; set; }
    }
}