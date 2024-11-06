using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortobanza1
{


    internal class Cliente

    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Codcliente { get; }

        public Cliente(string email, string senha, int codigo)
            : this(email,senha)
        { Codcliente = codigo; }


        public Cliente(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}



