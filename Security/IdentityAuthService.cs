using kanban.Domain.Communication;
using kanban.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanban.Security
{
    public class IdentityAuthService : IAuthService
    {
        public Task<TokenResponse> CreateAccessTokenAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<TokenResponse> RefreshTokenAsync(string refreshToken, string userEmail)
        {
            throw new NotImplementedException();
        }

        public void RevokeRefreshToken(string refreshToken)
        {
            throw new NotImplementedException();
        }
    }
}
