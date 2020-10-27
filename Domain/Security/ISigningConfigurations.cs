using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanban.Domain.Security
{
    public interface ISigningConfigurations
    {
        public SecurityKey SecurityKey { get; set; }
        public SigningCredentials SigningCredentials { get; set; }

    }
}
