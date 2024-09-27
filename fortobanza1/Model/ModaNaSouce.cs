using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace fortobanza1.Model
{
    internal class property
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public property (string email, string senha)
        {
            Senha = senha;
            Email = email;
        }
    }
}
