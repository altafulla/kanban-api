using Kanban.API.Domain.Models;
using Kanban.API.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanban.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> FindByName(string name);

    }
}
