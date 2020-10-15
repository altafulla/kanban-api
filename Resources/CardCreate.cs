using System.Collections.Generic;

namespace Kanban.API.Domain.Models
{
    public class CardCreate
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}