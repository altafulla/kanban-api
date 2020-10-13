using System.Collections.Generic;

namespace Kanban.API.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public IList<Board> Boards { get; set; }

    }
}