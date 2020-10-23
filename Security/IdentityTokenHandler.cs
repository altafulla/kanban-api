using kanban.Domain.Security;
using kanban.Domain.Security.Tokens;
using Kanban.API.Domain.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace kanban.Security
{
    public class IdentityTokenHandler : ITokenHandler
    {
        private readonly JwtSecurityTokenHandler _actualHandler;
        public IdentityTokenHandler()
        {
            _actualHandler = new JwtSecurityTokenHandler();
        }

        public AccessToken CreateAccessToken(User user)
        {
            throw new NotImplementedException();
        }

        public void RevokeRefreshToken(string token)
        {
            throw new NotImplementedException();
        }

        public RefreshToken TakeRefreshToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
