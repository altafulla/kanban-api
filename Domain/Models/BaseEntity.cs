using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.API.Domain.Models
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; } = false;
    }
}