using Kanban.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.API.Domain.Services
{
    public interface IUserService
    {
        public Task<User> FindByNameAsync(string name);

    }
}
