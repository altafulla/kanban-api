using System.Collections.Generic;

namespace kanban.API.Resources
{
    public class CardResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CardlistId { get; set; }

    }
}