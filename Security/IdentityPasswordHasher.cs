using kanban.Domain.Security;
using Microsoft.AspNetCore.Identity;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace kanban.Security
{
    public class IdentityPasswordHasher : IPasswordHasher
    {
        private readonly Microsoft.AspNetCore.Identity.IPasswordHasher<string> _actualHasher;

        public IdentityPasswordHasher()
        {
            _actualHasher = new PasswordHasher<string>();
        }

        public string HashPassword(string password)
        {
            return _actualHasher.HashPassword(null, password);
        }

        public bool PasswordMatches(string providedPassword, string passwordHash)
        {
            //PasswordVerificationResult _result = _actualHasher.VerifyHashedPassword(null, providedPassword, passwordHash);
            PasswordVerificationResult result = _actualHasher.VerifyHashedPassword(null, passwordHash, providedPassword);
            return result != PasswordVerificationResult.Failed;


        }
    }
}
