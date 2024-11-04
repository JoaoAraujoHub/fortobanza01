namespace fortobanza1
{
    internal class Usuario
    {
        private string senha;
        private string email;
        private string Id;

        public Usuario(string senha, string email, string id, string v)
        {
            this.senha = senha;
            this.email = email;
            Id = id;
        }
    }
}