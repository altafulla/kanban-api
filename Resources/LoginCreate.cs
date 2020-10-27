using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanban.API.Resources
{
    public class LoginCreate
    {
        public string Name { set; get; }
        public string Password { set; get; }
    }
}
