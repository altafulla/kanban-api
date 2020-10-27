using kanban.Domain.Communication;
using kanban.Domain.Security;
using Kanban.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanban.Security
{
    public class IdentityAuthService : IAuthService
    {
        private readonly IUserService _userService;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITokenHandler _tokenHandler;

        public IdentityAuthService(IUserService userService, IPasswordHasher passwordHasher, ITokenHandler tokenHandler)
        {
            _tokenHandler = tokenHandler;
            _passwordHasher = passwordHasher;
            _userService = userService;
        }
        public async Task<TokenResponse> CreateAccessTokenAsync(string name, string password)
        {
            var user = await _userService.FindByNameAsync(name);

            if(user == null || !_passwordHasher.PasswordMatches(password, user.Password))
            {
                return new TokenResponse(false, "Invalid credentials", null);
            }

            var token = _tokenHandler.CreateAccessToken(user);
            return new TokenResponse(true, null, token);
        }

        public async Task<TokenResponse> RefreshTokenAsync(string refreshToken, string userEmail)
        {
            var token = _tokenHandler.TakeRefreshToken(refreshToken);

            if (token == null)
            {
                return new TokenResponse(false, "Invalid refresh token.", null);
            }

            if (token.IsExpired())
            {
                return new TokenResponse(false, "Expired refresh token.", null);
            }

            var user = await _userService.FindByNameAsync(userEmail);
            if (user == null)
            {
                return new TokenResponse(false, "Invalid refresh token.", null);
            }

            var accessToken = _tokenHandler.CreateAccessToken(user);
            return new TokenResponse(true, null, accessToken);
        }

        public void RevokeRefreshToken(string refreshToken)
        {
            _tokenHandler.RevokeRefreshToken(refreshToken);
        }
    }
}
