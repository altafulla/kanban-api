using kanban.Domain.Repositories;
using Kanban.API.Domain.Models;
using Kanban.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace kanban.API.Services
{
    


    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> FindByNameAsync(string name)
        {
            return _userRepository.FindByName(name);
        }
    }
}
