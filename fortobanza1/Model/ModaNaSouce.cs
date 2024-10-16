using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace fortobanza1.Model
{
    internal class fortobanza1
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public fortobanza1 (string email, string senha)
        {
            Senha = senha;
            Email = email;
        }
    }
}
