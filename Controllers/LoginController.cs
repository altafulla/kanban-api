using AutoMapper;
using kanban.API.Resources;
using kanban.Domain.Communication;
using kanban.Domain.Security;
using Kanban.API.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanban.Controllers
{
    [Route("/api/[controller]")]

    public class LoginController
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IAuthService _authService;
        public LoginController(IMapper mapper, IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _mapper = mapper;
            _authService = authService;
        }
        [HttpPost]
        public async Task<TokenResponse> LoginAsync([FromBody] LoginCreate loginCreate)
        {
            return await _authService.CreateAccessTokenAsync(loginCreate.Name, loginCreate.Password);
        }
    }
}
