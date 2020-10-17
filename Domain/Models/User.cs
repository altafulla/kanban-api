using System.Collections.Generic;

namespace Kanban.API.Domain.Models
{
    public class User : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public IList<Board> Boards { get; set; }

    }
}