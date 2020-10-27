using kanban.Domain.Repositories;
using Kanban.API.Domain.Models;
using Kanban.API.Domain.Repositories;
using Kanban.API.Persistence.Contexts;
using Kanban.API.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanban.API.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> FindByName(string name)
        {
            var usersync = _context.Users.SingleOrDefault(u => u.Name == name);
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Name.ToLower() == name.ToLower());
            return user;
        }
    }
}
