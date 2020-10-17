using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.API.Domain.Models
{
    public interface IEntity
    {
        public int Id { set; get; }
        public bool Deleted { set; get; }

    }
}