using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanban.API.Resources
{
    public class RefreshTokenResource
    {
        public string Token { get; set; }
         
        public string UserEmail { get; set; }
    }
}
