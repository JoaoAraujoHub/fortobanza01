using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortobanza1
{
    internal class Property
    { }
}

        internal class cliente

        {
            public string Email { get; set; }
            public string Senha { get; set; }
            public string Id { get; set; }
            public int Codcliente { get; }

        public cliente(string email, string senha, string Id)
            : this(email,
                   senha) => Codcliente = Codcliente;

        public cliente(string email,
                       string senha,
                       string Id)
            {
                Id = Id;
                Email = email;
                Senha = senha;
            Id = Id;
            }

    public cliente(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }
}



