using kanban.Domain.Security;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanban.Security
{
    public class SigningConfigurations : ISigningConfigurations
    {
            public SecurityKey SecurityKey { get; set; }
            public SigningCredentials SigningCredentials { get; set; }

            public SigningConfigurations(string key)
            {
                var keyBytes = Encoding.ASCII.GetBytes(key);

                SecurityKey = new SymmetricSecurityKey(keyBytes);
                SigningCredentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256Signature);
            }
        
    }
}
